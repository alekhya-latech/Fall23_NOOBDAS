using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;
    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private HealingObject goldcoin;
    private HealingObject diamond;
    private FrmBattle frmBattle;
    private Character[] walls;
    private DateTime timeBegin;
   
    public FrmLevel(Image playerSkin) {
      InitializeComponent();
      const int PADDING = 7;
      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      picPlayer.BackgroundImage = playerSkin;
      player.Img = playerSkin;
      

        }
    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;

     
     
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
      
      goldcoin = new HealingObject(CreatePosition(picGoldCoin), CreateCollider(picGoldCoin, PADDING));
      diamond = new HealingObject(CreatePosition(picDiamond), CreateCollider(picDiamond, PADDING)); 
      
      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

      goldcoin.Img = picGoldCoin.BackgroundImage;
      diamond.Img = picDiamond.BackgroundImage;

      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      Game.player = player;
      timeBegin = DateTime.Now;
    }

    private Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    private Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      player.ResetMoveSpeed();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      TimeSpan span = DateTime.Now - timeBegin;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
    }

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
      // move player
      player.Move();

      // check collision with walls
      if (HitAWall(player)) {
        player.MoveBack();
      }

            // check collision with enemies
      if (HitAChar(player, enemyPoisonPacket) && picEnemyPoisonPacket!= null)
      {
        picEnemyPoisonPacket.Visible = false;
        Fight(enemyPoisonPacket);
        picEnemyPoisonPacket = null;
      }
      else if (HitAChar(player, enemyCheeto) && picEnemyCheeto!=null)
      {
        picEnemyCheeto.Visible = false;
        Fight(enemyCheeto);
        picEnemyCheeto = null;
      }
      if (HitAChar(player, bossKoolaid)) {
        Fight(bossKoolaid);
      }

      //check collision with Healing Objects
      if (HitAChar(player, goldcoin))
            {
                picGoldCoin.Visible = false;
                player.Health = 20;
            }

      if (HitAChar(player, diamond))
            {
                picDiamond.Visible = false;
                player.Health = 20;
            }

            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
            scoreDisplay.Text = player.Health.ToString();
           
    }

    private bool HitAWall(Character c) {
      bool hitAWall = false;
      for (int w = 0; w < walls.Length; w++) {
        if (c.Collider.Intersects(walls[w].Collider)) {
          hitAWall = true;
          break;
        }
      }
      return hitAWall;
    }

    private bool HitAChar(Character you, Character other) {
      return you.Collider.Intersects(other.Collider);
    }

    private void Fight(Enemy enemy) {
      player.ResetMoveSpeed();
      player.MoveBack();
      frmBattle = FrmBattle.GetInstance(enemy, player);
            if (enemy == bossKoolaid)
            {
                frmBattle.SetupForBossBattle();
            }
            frmBattle.Show();
      
      
    }

    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
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

        default:
          player.ResetMoveSpeed();
          break;
      }
    }

    private void lblInGameTime_Click(object sender, EventArgs e) {

    }
  }
}
