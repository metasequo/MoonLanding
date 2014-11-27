using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoonLanding
{
    public partial class MoonLanding : Form
    {
        public MoonLanding()
        {
            InitializeComponent();
        }

        //定数（月の重力加速度）
        static class Constants
        {
            public const double Gravity = -2.78;
        }

        bool Start = false;     //スタートボタンを推したかどうかのフラグ

        Lander Lander = new Lander();

        //初期化
        private void Format()
        {
            Start = false;
            Lander.Altitude = (int)InitialAltitude.Value;
            Lander.Velocity = 0;
            Lander.Acceleration = 0;
            Lander.Propellant = 300;
            NowAltitude.Text = Lander.Altitude.ToString();
            NowVelocity.Text = Lander.Velocity.ToString();
            RemainingPropellant.Text = Lander.Propellant.ToString();
        }

        //スタートフラグをチェック、その後計算
        private void CheckStart(bool Use)
        {
            if (Start)
            {
                Calc(Use);
            }
            else
            {
                MessageBox.Show("スタートボタンを押してください。", "未スタート",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //加速度、速度、高度を計算
        private void Calc(bool Use)
        {
            //推進剤が足りない時はメッセージを出す
            if (Use && Lander.Propellant < UsePropellant.Value)
            {
                MessageBox.Show("推進剤が足りません。", "推進剤不足",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //計算
                Lander.Acceleration = Constants.Gravity;
                if (Use)
                {
                    Lander.Acceleration += (double)UsePropellant.Value;
                }
                Lander.Velocity = Convert.ToDouble(NowVelocity.Text) * -1 + Lander.Acceleration;
                Lander.Altitude = Convert.ToDouble(NowAltitude.Text) + Lander.Velocity;

                //テキストボックスに表示
                if (Use)
                {
                    Lander.Propellant -= (int)UsePropellant.Value;
                }
                NowAltitude.Text = Lander.Altitude.ToString();
                NowVelocity.Text = (-Lander.Velocity).ToString();
                RemainingPropellant.Text = Lander.Propellant.ToString();

                //高度が1.0m以下になったら着陸判定する
                if (Lander.Altitude <= 1.0)
                {
                    Landing();
                }
            }
        }

        //着陸判定
        private void Landing(){
            if ((-1.0 <= Lander.Velocity && Lander.Velocity <= 1.0)
                && (0.0 <= Lander.Altitude && Lander.Altitude <= 1.0))
            {
                MessageBox.Show("おめでとうございます！着陸に成功しました！！", "着陸成功",
                    MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("残念ながら着陸に失敗しました･･･", "着陸失敗", MessageBoxButtons.OK);
            }

            DialogResult result = MessageBox.Show("ゲームを続けますか？", "ゲーム継続",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //初期化する
                Format();
            }
            else
            {
                //ゲームを終わる
                this.Close();
            }
        }

        //スタートボタンを押す
        private void StartButton_Click(object sender, EventArgs e)
        {
            Format();
            Start = true;
        }

        //推進剤使用ボタンを押す
        private void InjectionButton_Click(object sender, EventArgs e)
        {
            CheckStart(true);
        }

        //推進剤無使用ボタンを押す
        private void NonInjectionButton_Click(object sender, EventArgs e)
        {
            CheckStart(false);
        }

        //終了ボタンを押す
        private void EndButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
