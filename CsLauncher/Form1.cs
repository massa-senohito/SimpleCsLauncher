using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetShellIcon;

namespace CsLauncher
{
    public partial class LauncherForm : Form
    {
        List<ToolStripItem> QuickSaveItemList = new List<ToolStripItem>();
        string FirstCurrent ;
        public LauncherForm( )
        {
            InitializeComponent( );
            PathListBox.MouseUp += ListBox1_MouseUp;
            // 縦の割線を固定する
            foreach ( ColumnStyle item in tableLayoutPanel1.ColumnStyles )
            {
                var w = item.Width;
                item.SizeType = SizeType.Absolute;
                item.Width = 16.0f;
                //Debugger.Break( );

            }
            FirstCurrent = Environment.CurrentDirectory;
            UpdateQSaveList( );
            QuickLoad( );
            var icon = Directory.CreateDirectory( "Icons" );
        }

        bool IsQSaveFile(string path)
        {
            return !path.Contains("~" );
        }
        private void UpdateQSaveList( )
        {
            InitQsaveClick( );
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var quicksaveList = Directory.GetFiles( baseDir , "*.txt").Where(IsQSaveFile);
            foreach ( var item in quicksaveList )
            {
                var fileName = Path.GetFileName(item);
                var dropdownItem = saveListToolStripMenuItem.DropDownItems.Add( fileName );
                dropdownItem.Click += DropdownItem_Click;
                QuickSaveItemList.Add( dropdownItem );
            }
        }

        private void DropdownItem_Click( object sender , EventArgs e )
        {
            var toolItem = (ToolStripItem)sender;
            QuickLoad( toolItem.Text );
        }

        private void Form1_FormClosed( object sender , FormClosedEventArgs e )
        {
            InitQsaveClick( );
        }

        private void InitQsaveClick( )
        {
            foreach ( var item in QuickSaveItemList )
            {
                item.Click -= DropdownItem_Click;
            }
            saveListToolStripMenuItem.DropDownItems.Clear( );
        }

        private void ListBox1_MouseUp( object sender , MouseEventArgs e )
        {
            int index = PathListBox.IndexFromPoint(e.Location);
            if ( index != ListBox.NoMatches )
            {
                string fileName = PathListBox.Items[index] as string;
                if ( e.Button == MouseButtons.Left )
                {
                    // 存在しないパスならコメントとする
                    if ( fileName == "" ) return;
                    if ( fileName.IsPathExist( ) )
                    {
                        var parent = Directory.GetParent(fileName).FullName;
                        Environment.CurrentDirectory = parent;
                        var proc = Process.Start( fileName );
                        Environment.CurrentDirectory = FirstCurrent;
                        //proc.StartInfo.EnvironmentVariables.
                    }
                    if ( fileName.StartsWith( "http" ) )
                    {
                        Process.Start( fileName );
                    }
                }
                // 右クリックなら要素削除、中クリックなら親フォルダを開く
                else if(e.Button == MouseButtons.Right )
                {
                    PathListBox.Items.RemoveAt( index );
                    Redraw( );
                }
                else
                {
                    OpenParent( fileName );

                }
            }
            else
            {
                // 試しに更新
                UpdateQSaveList( );
                OpenParent( OpeningPath );
            }
        }

        private static void OpenParent( string fileName )
        {
            var parent = Directory.GetParent(fileName);
            if ( parent != null )
            {
                Process.Start( parent.FullName );
            }
        }

        IEnumerable<string> ListBoxItem( )
        {
            foreach ( var item in PathListBox.Items )
            {
                var i = item as string;
                yield return i;
            }
        }

        private void addFromCBToolStripMenuItem_Click( object sender , EventArgs e )
        {
            if ( Clipboard.ContainsText( ) )
            {
                PathListBox.Items.Add( Clipboard.GetText( ) );
            }
            quickSaveToolStripMenuItem_Click( null , null );
        }

        private void Redraw( )
        {
            tableLayoutPanel1.Invalidate( );
        }

        private void quickSaveToolStripMenuItem_Click( object sender , EventArgs e )
        {
            Redraw( );
            IEnumerable<string> contents = ListBoxItem();
            // 空ならセーブしない
            if ( contents.Count( ) == 0 ) return;
            // セーブパスをDivideに渡す
            File.WriteAllLines( OpeningPath , contents );
        }

        private void quickLoadToolStripMenuItem_Click( object sender , EventArgs e )
        {
            QuickLoad( Path.GetFileName( OpeningPath ) );
        }

        string OpeningPath;

        private void QuickLoad( string name = "QSave.txt"  )
        {
            Redraw( );
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            try
            {
                PathListBox.Items.Clear( );
                string filePath = baseDir + name;
                OpeningPath = filePath;
                this.Text = name;
                string[ ] items = File.ReadAllLines( filePath );
                PathListBox.Items.AddRange( items );
            }
            catch ( Exception ex )
            {
                // QSaveがない時
                MessageBox.Show( ex.Message );
            }
        }

        private void Form1_Paint( object sender , PaintEventArgs e )
        {

        }

        Icon IconFromPath( string filename )
        {
            Icon myIcon = SystemIcons.Error;
            try
            {
                WindowsShellAPI.SHFILEINFO shinfo= new WindowsShellAPI.SHFILEINFO();
                IntPtr hImg = WindowsShellAPI.SHGetFileInfo(
                filename, 0, out shinfo, (uint)Marshal.SizeOf(typeof(WindowsShellAPI.SHFILEINFO)),
                WindowsShellAPI.SHGFI.SHGFI_ICON | WindowsShellAPI.SHGFI.SHGFI_LARGEICON);

                myIcon = Icon.FromHandle(shinfo.hIcon);
            }
            catch(Exception exn)
            {
                Trace.WriteLine( exn.ToString( ) );
            }
            return myIcon;
        }

        Dictionary<string,Icon> PathToIcon = new Dictionary<string, Icon>();

        private void Layout_Paint( object sender , PaintEventArgs e )
        {
            for ( int i = 0 ; i < PathListBox.Items.Count ; i++ )
            {
                var item = PathListBox.Items[i] as string;
                var yOffset = 4;
                var wSize = 16;
                var hSize = 16;
                var rect = new Rectangle(0, i * hSize + yOffset , wSize , hSize);
                ulong hash = XXHash.XXHash64.Hash( item );
                // ネットワークドライブのパスなら生成に時間がかかるので作らない
                bool needIcon = item.IsPathExist() && !item.StartsWith("\\\\");
                var icon = new DirectoryInfo("Icons");
                string fullPath = icon.FullName + Path.DirectorySeparatorChar + hash.ToString( ) + ".ico";
                if ( needIcon )
                {
                    Icon appIcon;
                    if ( File.Exists( fullPath ) )
                    {
                        if(PathToIcon.ContainsKey(fullPath))
                        {
                            appIcon = PathToIcon[ fullPath ];
                        }
                        else
                        {
                            appIcon = new Icon( fullPath );
                            PathToIcon.Add( fullPath , appIcon );
                        }
                    }
                    else
                    {
                        appIcon = IconFromPath( item );
                        using (var saveStr = new StreamWriter( fullPath ) )
                          appIcon.Save( saveStr.BaseStream );
                        PathToIcon.Add( fullPath , appIcon );
                    }
                    e.Graphics.DrawIcon( appIcon , rect );
                }
            }
        }

        private void PathListBox_DragDrop( object sender , DragEventArgs e )
        {
            var isFileDrop = e.Data.GetDataPresent( DataFormats.FileDrop );
            if ( isFileDrop )
            {
                foreach ( var filePath in ( string[ ] )e.Data.GetData( DataFormats.FileDrop ) )
                {
                    PathListBox.Items.Add( filePath );
                }
                quickSaveToolStripMenuItem_Click( null , null );
                Redraw( );
            }
        }

        private void PathListBox_DragEnter( object sender , DragEventArgs e )
        {
            e.Effect = DragDropEffects.All;
        }

        private void OpenQSaveToolStripMenuItem_Click( object sender , EventArgs e )
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var qsavePath = //baseDir + "QSave.txt";
                OpeningPath;
            Process.Start( qsavePath );
        }

        private void LauncherForm_MouseClick( object sender , MouseEventArgs e )
        {
        }

        private void divideSaveToolStripMenuItem_Click( object sender , EventArgs e )
        {
            var divideSave = new DivideSaveForm();
            divideSave.Init( PathListBox.Items , OpeningPath);
            divideSave.ShowDialog( );
            QuickLoad( Path.GetFileName( OpeningPath ) );
            UpdateQSaveList( );
        }
    }
}

