using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsLauncher
{
    public partial class DivideSaveForm : Form
    {
        public DivideSaveForm( )
        {
            InitializeComponent( );
            FromBox.KeyDown += DivideSaveForm_KeyDown;
        }

        private void DivideSaveForm_KeyDown( object sender , KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Right )
            {
                ToRightCommand( );
            }
        }

        string OpeningPath;
        public void Init( ListBox.ObjectCollection list , string openingPath )
        {
            FromBox.Items.AddRange( list );
            OpeningPath = openingPath;
        }

        private void DivideSaveForm_Load( object sender , EventArgs e )
        {

        }

        private void ToRight_Click( object sender , EventArgs e )
        {
            ToRightCommand( );
        }

        private void ToRightCommand( )
        {
            var selected = FromBox.SelectedItems;
            NewBox.Items.AddRange( selected.Cast<string>( ).ToArray( ) );
            var selList = selected.Cast<string>().ToArray();
            foreach ( var ind in selList )
            {
                FromBox.Items.Remove( ind );
            }
        }

        IEnumerable<string> ListBoxItem( ListBox pathListBox )
        {
            foreach ( var item in pathListBox.Items )
            {
                var i = item as string;
                yield return i;
            }
        }

        private void SaveButton_Click( object sender , EventArgs e )
        {
            // 両方move
            var fromList = ListBoxItem( FromBox );
            var toList = ListBoxItem( NewBox );
            var toPath =
                Directory.GetParent(OpeningPath).FullName +
                Path.DirectorySeparatorChar +
                Path.GetFileNameWithoutExtension( OpeningPath ) +
                "NewPath.txt";
            File.WriteAllLines( OpeningPath , fromList );
            File.WriteAllLines( toPath , toList );
        }
    }
}
