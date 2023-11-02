using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmHardLevel : Form
    {
        public FrmHardLevel(Image playerSkin)
        {
            InitializeComponent();
            const int PADDING = 7;
            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            picPlayer.BackgroundImage = playerSkin;
            player.Img = playerSkin;
        }

        }
    }