
using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Linq;
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
        private Weapon poison, gun, fire;
        private FrmBattle frmBattle;
        private Character[] walls;
        private HealingObject[] healingObjects;
        private System.Windows.Forms.Timer tmrPlayerMove;
        private PictureBox picWall7;
        private PictureBox picWall8;
        private PictureBox picWall9;
        private PictureBox health1;
        private PictureBox health4;
        private PictureBox health3;
        private PictureBox health2;
        private PictureBox health5;
        private PictureBox poisonhealth1;
        private PictureBox weapon1;
        private PictureBox weapon2;
        private PictureBox weapon3;
        private PictureBox picpoison;
        private PictureBox picfire;
        private PictureBox pictureBox1;
        private PictureBox health0;
        private PictureBox cheetohealth1;
        private PictureBox cheetohealth2;
        private PictureBox koolhealth3;
        private PictureBox koolhealth2;
        private PictureBox koolhealth1;
        private PictureBox picgun;
        private System.ComponentModel.IContainer components = null;
        private ProgressBar progressBar;
        private Label lblInGameTime;
        private System.Windows.Forms.Timer tmrUpdateInGameTime;
        private DateTime timeBegin;
        private bool isGamePaused = false;
        private TimeSpan span, pauseSpan = TimeSpan.Zero;
        private DateTime pauseStart;
        private Label heartsCount;
        private PictureBox pictureBox2;
        private MenuForm menuForm = new MenuForm();


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
            const int NUM_HEALING_OBJECTS = 6;
            bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));


            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            healingObjects = new HealingObject[NUM_HEALING_OBJECTS];
            for(int h =0; h < NUM_HEALING_OBJECTS; h++)
            {
                PictureBox pic = Controls.Find("health" + h.ToString(), true)[0] as PictureBox;
                healingObjects[h] = new HealingObject(CreatePosition(pic), CreateCollider(pic, PADDING));

            }

            poison = new Weapon(CreatePosition(picpoison), CreateCollider(picpoison, PADDING));
            fire = new Weapon(CreatePosition(picfire), CreateCollider(picfire, PADDING));
            gun = new Weapon(CreatePosition(picgun), CreateCollider(picgun, PADDING));

            timeBegin = DateTime.Now;
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
            this.health1 = new System.Windows.Forms.PictureBox();
            this.health4 = new System.Windows.Forms.PictureBox();
            this.health3 = new System.Windows.Forms.PictureBox();
            this.health2 = new System.Windows.Forms.PictureBox();
            this.health5 = new System.Windows.Forms.PictureBox();
            this.poisonhealth1 = new System.Windows.Forms.PictureBox();
            this.weapon1 = new System.Windows.Forms.PictureBox();
            this.weapon2 = new System.Windows.Forms.PictureBox();
            this.weapon3 = new System.Windows.Forms.PictureBox();
            this.picpoison = new System.Windows.Forms.PictureBox();
            this.picfire = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.health0 = new System.Windows.Forms.PictureBox();
            this.cheetohealth1 = new System.Windows.Forms.PictureBox();
            this.cheetohealth2 = new System.Windows.Forms.PictureBox();
            this.koolhealth3 = new System.Windows.Forms.PictureBox();
            this.koolhealth2 = new System.Windows.Forms.PictureBox();
            this.koolhealth1 = new System.Windows.Forms.PictureBox();
            this.picgun = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.heartsCount = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.health1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisonhealth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weapon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weapon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weapon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpoison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheetohealth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheetohealth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koolhealth3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koolhealth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koolhealth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picgun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.picWall3.Location = new System.Drawing.Point(542, 335);
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
            this.picWall6.Size = new System.Drawing.Size(189, 32);
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
            this.picWall2.Location = new System.Drawing.Point(824, 355);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(38, 206);
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
            this.picEnemyCheeto.Location = new System.Drawing.Point(641, 105);
            this.picEnemyCheeto.Name = "picEnemyCheeto";
            this.picEnemyCheeto.Size = new System.Drawing.Size(100, 142);
            this.picEnemyCheeto.TabIndex = 9;
            this.picEnemyCheeto.TabStop = false;
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_koolaid;
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(1012, 35);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(198, 188);
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
            // health1
            // 
            this.health1.BackColor = System.Drawing.Color.Transparent;
            this.health1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.heart;
            this.health1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.health1.Location = new System.Drawing.Point(247, 373);
            this.health1.Name = "health1";
            this.health1.Size = new System.Drawing.Size(29, 22);
            this.health1.TabIndex = 14;
            this.health1.TabStop = false;
            // 
            // health4
            // 
            this.health4.BackColor = System.Drawing.Color.Transparent;
            this.health4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.heart;
            this.health4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.health4.Location = new System.Drawing.Point(511, 122);
            this.health4.Name = "health4";
            this.health4.Size = new System.Drawing.Size(28, 24);
            this.health4.TabIndex = 15;
            this.health4.TabStop = false;
            // 
            // health3
            // 
            this.health3.BackColor = System.Drawing.Color.Transparent;
            this.health3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.heart;
            this.health3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.health3.Location = new System.Drawing.Point(275, 122);
            this.health3.Name = "health3";
            this.health3.Size = new System.Drawing.Size(29, 24);
            this.health3.TabIndex = 16;
            this.health3.TabStop = false;
            // 
            // health2
            // 
            this.health2.BackColor = System.Drawing.Color.Transparent;
            this.health2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.heart;
            this.health2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.health2.Location = new System.Drawing.Point(45, 312);
            this.health2.Name = "health2";
            this.health2.Size = new System.Drawing.Size(26, 17);
            this.health2.TabIndex = 17;
            this.health2.TabStop = false;
            // 
            // health5
            // 
            this.health5.BackColor = System.Drawing.Color.Transparent;
            this.health5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.heart;
            this.health5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.health5.Location = new System.Drawing.Point(868, 533);
            this.health5.Name = "health5";
            this.health5.Size = new System.Drawing.Size(29, 19);
            this.health5.TabIndex = 18;
            this.health5.TabStop = false;
            // 
            // poisonhealth1
            // 
            this.poisonhealth1.BackColor = System.Drawing.Color.Transparent;
            this.poisonhealth1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.heart;
            this.poisonhealth1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.poisonhealth1.Location = new System.Drawing.Point(464, 392);
            this.poisonhealth1.Name = "poisonhealth1";
            this.poisonhealth1.Size = new System.Drawing.Size(16, 11);
            this.poisonhealth1.TabIndex = 20;
            this.poisonhealth1.TabStop = false;
            // 
            // weapon1
            // 
            this.weapon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weapon1.Location = new System.Drawing.Point(0, 491);
            this.weapon1.Name = "weapon1";
            this.weapon1.Size = new System.Drawing.Size(43, 36);
            this.weapon1.TabIndex = 22;
            this.weapon1.TabStop = false;
            // 
            // weapon2
            // 
            this.weapon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weapon2.Location = new System.Drawing.Point(0, 533);
            this.weapon2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.weapon2.Name = "weapon2";
            this.weapon2.Size = new System.Drawing.Size(43, 36);
            this.weapon2.TabIndex = 23;
            this.weapon2.TabStop = false;
            // 
            // weapon3
            // 
            this.weapon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weapon3.Location = new System.Drawing.Point(0, 570);
            this.weapon3.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.weapon3.Name = "weapon3";
            this.weapon3.Size = new System.Drawing.Size(43, 36);
            this.weapon3.TabIndex = 24;
            this.weapon3.TabStop = false;
            // 
            // picpoison
            // 
            this.picpoison.BackColor = System.Drawing.Color.Transparent;
            this.picpoison.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.poison;
            this.picpoison.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picpoison.Location = new System.Drawing.Point(209, 511);
            this.picpoison.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picpoison.Name = "picpoison";
            this.picpoison.Size = new System.Drawing.Size(49, 64);
            this.picpoison.TabIndex = 25;
            this.picpoison.TabStop = false;
            // 
            // picfire
            // 
            this.picfire.BackColor = System.Drawing.Color.Transparent;
            this.picfire.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.water;
            this.picfire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picfire.Location = new System.Drawing.Point(45, 105);
            this.picfire.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picfire.Name = "picfire";
            this.picfire.Size = new System.Drawing.Size(116, 97);
            this.picfire.TabIndex = 26;
            this.picfire.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.pictureBox1.Location = new System.Drawing.Point(1100, 335);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 32);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // health0
            // 
            this.health0.BackColor = System.Drawing.Color.Transparent;
            this.health0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.heart;
            this.health0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.health0.Location = new System.Drawing.Point(1120, 312);
            this.health0.Name = "health0";
            this.health0.Size = new System.Drawing.Size(27, 17);
            this.health0.TabIndex = 30;
            this.health0.TabStop = false;
            // 
            // cheetohealth1
            // 
            this.cheetohealth1.BackColor = System.Drawing.Color.Transparent;
            this.cheetohealth1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.heart;
            this.cheetohealth1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cheetohealth1.Location = new System.Drawing.Point(724, 101);
            this.cheetohealth1.Name = "cheetohealth1";
            this.cheetohealth1.Size = new System.Drawing.Size(17, 12);
            this.cheetohealth1.TabIndex = 31;
            this.cheetohealth1.TabStop = false;
            // 
            // cheetohealth2
            // 
            this.cheetohealth2.BackColor = System.Drawing.Color.Transparent;
            this.cheetohealth2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.heart;
            this.cheetohealth2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cheetohealth2.Location = new System.Drawing.Point(738, 101);
            this.cheetohealth2.Name = "cheetohealth2";
            this.cheetohealth2.Size = new System.Drawing.Size(17, 12);
            this.cheetohealth2.TabIndex = 33;
            this.cheetohealth2.TabStop = false;
            // 
            // koolhealth3
            // 
            this.koolhealth3.BackColor = System.Drawing.Color.Transparent;
            this.koolhealth3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.heart;
            this.koolhealth3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.koolhealth3.Location = new System.Drawing.Point(1120, 45);
            this.koolhealth3.Name = "koolhealth3";
            this.koolhealth3.Size = new System.Drawing.Size(17, 12);
            this.koolhealth3.TabIndex = 35;
            this.koolhealth3.TabStop = false;
            // 
            // koolhealth2
            // 
            this.koolhealth2.BackColor = System.Drawing.Color.Transparent;
            this.koolhealth2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.heart;
            this.koolhealth2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.koolhealth2.Location = new System.Drawing.Point(1100, 45);
            this.koolhealth2.Name = "koolhealth2";
            this.koolhealth2.Size = new System.Drawing.Size(17, 12);
            this.koolhealth2.TabIndex = 36;
            this.koolhealth2.TabStop = false;
            // 
            // koolhealth1
            // 
            this.koolhealth1.BackColor = System.Drawing.Color.Transparent;
            this.koolhealth1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.heart;
            this.koolhealth1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.koolhealth1.Location = new System.Drawing.Point(1083, 45);
            this.koolhealth1.Name = "koolhealth1";
            this.koolhealth1.Size = new System.Drawing.Size(17, 12);
            this.koolhealth1.TabIndex = 37;
            this.koolhealth1.TabStop = false;
            // 
            // picgun
            // 
            this.picgun.BackColor = System.Drawing.Color.Transparent;
            this.picgun.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.gun;
            this.picgun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picgun.Location = new System.Drawing.Point(1110, 373);
            this.picgun.Name = "picgun";
            this.picgun.Size = new System.Drawing.Size(100, 66);
            this.picgun.TabIndex = 38;
            this.picgun.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.progressBar.Location = new System.Drawing.Point(1100, 6);
            this.progressBar.Maximum = 6;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 39;
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.Location = new System.Drawing.Point(12, 6);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(51, 20);
            this.lblInGameTime.TabIndex = 40;
            this.lblInGameTime.Text = "label1";
            // 
            // tmrUpdateInGameTime
            // 
            this.tmrUpdateInGameTime.Enabled = true;
            this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
            // 
            // heartsCount
            // 
            this.heartsCount.AutoSize = true;
            this.heartsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heartsCount.Location = new System.Drawing.Point(1201, 6);
            this.heartsCount.Name = "heartsCount";
            this.heartsCount.Size = new System.Drawing.Size(24, 26);
            this.heartsCount.TabIndex = 41;
            this.heartsCount.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.heart;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1064, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 20);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // FrmHardLevel
            // 
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.texture;
            this.ClientSize = new System.Drawing.Size(1284, 699);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.heartsCount);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.picgun);
            this.Controls.Add(this.koolhealth1);
            this.Controls.Add(this.koolhealth2);
            this.Controls.Add(this.koolhealth3);
            this.Controls.Add(this.cheetohealth2);
            this.Controls.Add(this.cheetohealth1);
            this.Controls.Add(this.health0);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picfire);
            this.Controls.Add(this.picpoison);
            this.Controls.Add(this.weapon3);
            this.Controls.Add(this.weapon2);
            this.Controls.Add(this.weapon1);
            this.Controls.Add(this.poisonhealth1);
            this.Controls.Add(this.health5);
            this.Controls.Add(this.health2);
            this.Controls.Add(this.health3);
            this.Controls.Add(this.health4);
            this.Controls.Add(this.health1);
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
            ((System.ComponentModel.ISupportInitialize)(this.health1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisonhealth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weapon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weapon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weapon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpoison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheetohealth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheetohealth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koolhealth3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koolhealth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koolhealth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picgun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            if (isGamePaused)
            {

                return;
            }
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
                if (weapon1.BackgroundImage != null  && progressBar.Value>=1)
                {
                        picEnemyPoisonPacket.Visible = false;
                        picEnemyPoisonPacket = null;

                        poisonhealth1.Visible = false;
                        poisonhealth1 = null;

                    progressBar.Value -= 1;
                    heartsCount.Text = (progressBar.Value).ToString();
                }
                else
                {
                    picEnemyPoisonPacket.Visible = false;
                    picEnemyPoisonPacket = null;
                    
                   
                    ResultForm resultForm = new ResultForm(false);
                    resultForm.ShowDialog();
                    

                }
            }
            else if (HitAChar(player, enemyCheeto) && picEnemyCheeto != null)
            {
                if (weapon2.BackgroundImage != null && progressBar.Value >= 2)
                {
                    picEnemyCheeto.Visible = false;
                    picEnemyCheeto = null;

                    cheetohealth1.Visible = false;
                    cheetohealth1 = null;

                    cheetohealth2.Visible = false;
                    cheetohealth2 = null;

                    progressBar.Value -= 2;
                    heartsCount.Text = (progressBar.Value).ToString();
                }
                else
                {
                    picEnemyCheeto.Visible = false;
                    picEnemyCheeto = null;

                    ResultForm resultForm = new ResultForm(false);
                    resultForm.ShowDialog();


                }
            }
            if (HitAChar(player, bossKoolaid) && picBossKoolAid != null)
            {
                if (weapon3.BackgroundImage != null && progressBar.Value >= 3)
                {
                    picBossKoolAid.Visible = false;
                    picBossKoolAid = null;
                    Close();
                    ResultForm resultForm = new ResultForm(true);
                    resultForm.ShowDialog();
                   

                   
                }
                else
                {
                    picBossKoolAid.Visible = false;
                    picBossKoolAid = null;
                    Close();
                    ResultForm resultForm = new ResultForm(false);
                    resultForm.ShowDialog();


                }
            }

            //check collision with health objects
            if(HitAChar(player, healingObjects[0]) && health0 != null)
            {
                health0.Visible = false;
                progressBar.PerformStep();
                heartsCount.Text = (progressBar.Value).ToString();
                health0 = null;

            }
            if (HitAChar(player, healingObjects[1]) && health1!= null)
            {
                health1.Visible = false;
                progressBar.PerformStep();
                heartsCount.Text = (progressBar.Value).ToString();
                health1 = null;
            }
            if (HitAChar(player, healingObjects[2]) && health2 != null)
            {
                health2.Visible = false;
                progressBar.PerformStep();
                heartsCount.Text = (progressBar.Value).ToString();
                health2 = null;
            }
            if (HitAChar(player, healingObjects[3]) && health3 != null)
            {
                health3.Visible = false;
                progressBar.PerformStep();
                health3 = null;
            }
            if (HitAChar(player, healingObjects[4]) && health4 != null)
            {
                health4.Visible = false;
                progressBar.PerformStep();
                heartsCount.Text = (progressBar.Value).ToString();
                health4 = null;
            }
            if (HitAChar(player, healingObjects[5]) && health5 != null)
            {
                health5.Visible = false;
                progressBar.PerformStep();
                heartsCount.Text = (progressBar.Value).ToString();
                health5 = null;
            }
          

            if (HitAChar(player, poison) && picpoison!=null)
            {
                weapon1.BackgroundImage = picpoison.BackgroundImage;
                picpoison.Visible = false;
                picpoison = null;
            }

            if (HitAChar(player, fire) && picfire != null)
            {
                weapon2.BackgroundImage = picfire.BackgroundImage;
                picfire.Visible = false;
                picfire = null;
            }

            if (HitAChar(player, gun) && picgun != null)
            {
                weapon3.BackgroundImage = picgun.BackgroundImage;
                picgun.Visible = false;
                picgun = null;
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
                    Game_Status();
                    break;

                case Keys.Escape:
                    menuForm.ShowDialog();
                    break;

                default:
                    player.ResetMoveSpeed();
                    break;
            }
        }

        private void Game_Status()
        {
            if (isGamePaused)
            {
                pauseSpan += DateTime.Now - pauseStart;
                isGamePaused = false;

            }
            else
            {
                pauseStart = DateTime.Now;
                isGamePaused = true;
            }
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            if (isGamePaused)
            {
                lblInGameTime.Text = lblInGameTime.Text;
            }

            else
            {
                span = DateTime.Now - timeBegin;
                string time = (span - pauseSpan).ToString(@"hh\:mm\:ss");
                lblInGameTime.Text = "Time: " + time.ToString();
            }
        }
    }
}