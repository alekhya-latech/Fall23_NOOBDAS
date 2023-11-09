using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmHardLevel : Form
    {
        private PictureBox picWall3;
        private PictureBox picWall6;
        private PictureBox picWall5;
        private PictureBox picWall2;
        private PictureBox picWall0;
        private PictureBox picWall4;
        private PictureBox picPlayer;
        private PictureBox picWall1;
        private PictureBox picEnemyPoisonPacket;
        private PictureBox picEnemyCheeto;
        private PictureBox picBossKoolAid;
        private Player player;
        private Enemy bossKoolaid, enemyPoisonPacket, enemyCheeto;
        private FrmBattle frmBattle;
        private Character[] walls;
        private System.Windows.Forms.Timer tmrPlayerMove;
        private PictureBox picWall7;
        private PictureBox picWall8;
        private PictureBox picWall9;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private System.ComponentModel.IContainer components = null;


        public FrmHardLevel(Image playerSkin)
        {
          const int PADDING = 0;
          InitializeComponent();
          Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
          player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
          picPlayer.BackgroundImage = playerSkin;
          player.Img = playerSkin;
          


        }

        private void FrmHardLevel_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 7;
            bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
            this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
            this.picBossKoolAid = new System.Windows.Forms.PictureBox();
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.picWall8 = new System.Windows.Forms.PictureBox();
            this.picWall9 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // picWall1
            // 
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall1.Location = new System.Drawing.Point(275, 520);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(276, 32);
            this.picWall1.TabIndex = 0;
            this.picWall1.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall3.Location = new System.Drawing.Point(548, 335);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(276, 32);
            this.picWall3.TabIndex = 1;
            this.picWall3.TabStop = false;
            // 
            // picWall6
            // 
            this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall6.Location = new System.Drawing.Point(824, 152);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(276, 32);
            this.picWall6.TabIndex = 2;
            this.picWall6.TabStop = false;
            // 
            // picWall5
            // 
            this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall5.Location = new System.Drawing.Point(275, 152);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(276, 32);
            this.picWall5.TabIndex = 3;
            this.picWall5.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall2.Location = new System.Drawing.Point(824, 520);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(276, 32);
            this.picWall2.TabIndex = 4;
            this.picWall2.TabStop = false;
            // 
            // picWall0
            // 
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall0.Location = new System.Drawing.Point(0, 612);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(1255, 32);
            this.picWall0.TabIndex = 5;
            this.picWall0.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall4.Location = new System.Drawing.Point(0, 335);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(276, 32);
            this.picWall4.TabIndex = 6;
            this.picWall4.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(45, 501);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(100, 105);
            this.picPlayer.TabIndex = 7;
            this.picPlayer.TabStop = false;
            // 
            // picEnemyPoisonPacket
            // 
            this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyPoisonPacket.Location = new System.Drawing.Point(451, 409);
            this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
            this.picEnemyPoisonPacket.Size = new System.Drawing.Size(100, 105);
            this.picEnemyPoisonPacket.TabIndex = 8;
            this.picEnemyPoisonPacket.TabStop = false;
            // 
            // picEnemyCheeto
            // 
            this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyCheeto.Location = new System.Drawing.Point(724, 224);
            this.picEnemyCheeto.Name = "picEnemyCheeto";
            this.picEnemyCheeto.Size = new System.Drawing.Size(100, 105);
            this.picEnemyCheeto.TabIndex = 9;
            this.picEnemyCheeto.TabStop = false;
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_koolaid;
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(1000, 41);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(100, 105);
            this.picBossKoolAid.TabIndex = 10;
            this.picBossKoolAid.TabStop = false;
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // picWall7
            // 
            this.picWall7.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall7.Location = new System.Drawing.Point(0, -3);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(1255, 32);
            this.picWall7.TabIndex = 11;
            this.picWall7.TabStop = false;
            // 
            // picWall8
            // 
            this.picWall8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall8.Location = new System.Drawing.Point(0, 25);
            this.picWall8.Name = "picWall8";
            this.picWall8.Size = new System.Drawing.Size(39, 587);
            this.picWall8.TabIndex = 12;
            this.picWall8.TabStop = false;
            // 
            // picWall9
            // 
            this.picWall9.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall9.Location = new System.Drawing.Point(1216, 25);
            this.picWall9.Name = "picWall9";
            this.picWall9.Size = new System.Drawing.Size(39, 587);
            this.picWall9.TabIndex = 13;
            this.picWall9.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.heart;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(275, 481);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 33);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.heart;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(511, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 33);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.heart;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(275, 113);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 33);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.heart;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(45, 296);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 33);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.heart;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(833, 471);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 33);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.heart;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(1043, 471);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 33);
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // FrmHardLevel
            // 
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.texture;
            this.ClientSize = new System.Drawing.Size(1250, 699);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picWall9);
            this.Controls.Add(this.picWall8);
            this.Controls.Add(this.picWall7);
            this.Controls.Add(this.picBossKoolAid);
            this.Controls.Add(this.picEnemyCheeto);
            this.Controls.Add(this.picEnemyPoisonPacket);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall5);
            this.Controls.Add(this.picWall6);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picWall1);
            this.HelpButton = true;
            this.Name = "FrmHardLevel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHardLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmHardLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmHardLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            // move player
            player.Move();

            // check collision with walls
            if (HitAWall(player))
            {
                player.MoveBack();
            }

            // check collision with enemies
            if (HitAChar(player, enemyPoisonPacket) && picEnemyPoisonPacket != null)
            {
                picEnemyPoisonPacket.Visible = false;
                Fight(enemyPoisonPacket);
                picEnemyPoisonPacket = null;
            }
            else if (HitAChar(player, enemyCheeto) && picEnemyCheeto != null)
            {
                picEnemyCheeto.Visible = false;
                Fight(enemyCheeto);
                picEnemyCheeto = null;
            }
            if (HitAChar(player, bossKoolaid))
            {
                Fight(bossKoolaid);
            }

            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
        }

        private bool HitAWall(Character c)
        {
            bool hitAWall = false;
            for (int w = 0; w < walls.Length; w++)
            {
                if (c.Collider.Intersects(walls[w].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }

        private bool HitAChar(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
        }

        private void Fight(Enemy enemy)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(enemy, player);
            if (enemy == bossKoolaid)
            {
                frmBattle.SetupForBossBattle();
            }
            frmBattle.Show();


        }

        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        private Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }

        private void FrmHardLevel_KeyUp(object sender, KeyEventArgs e)
        {
            player.ResetMoveSpeed();
        }

        private void FrmHardLevel_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player.GoLeft();
                    break;

                case Keys.Right:
                    player.GoRight();
                    break;

                case Keys.Up:
                    player.GoUp();
                    break;

                case Keys.Down:
                    player.GoDown();
                    break;

                case Keys.Space:
                    player.Jump();
                    break;

                default:
                    player.ResetMoveSpeed();
                    break;
            }
        }

    }
}