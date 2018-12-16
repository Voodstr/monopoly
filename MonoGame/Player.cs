using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MonoGame
{
    class Player
    {
        Point Location;
        Size size, pole;
        int df;                     //ширина поля
        int df2;

        Color clr;
        public int money;
        public int fnum=0;
        public Player(Color c, int m, Point p,Size s, Size pol)
        {
            clr = c;
            money = m;
            Location = p;
            size = s;
            pole = pol;
            df2 = df / 2;
        }
        public void Show(Graphics e)
        {
            SolidBrush b = new SolidBrush(clr);
            e.FillEllipse(b, Location.X, Location.Y, size.Width, size.Height);
            b.Dispose();
        }
        public void move(int f)
        {
            fnum += f;
            if (fnum >= 40)
            {
                fnum -= 40;
            }
            if (fnum <= 10){
                Location.X = (fnum * df)-df2;
                Location.Y = df2;
            }else if ((10<fnum)&&(fnum <= 20))
            {
                Location.Y = (fnum * df) - df2;
                Location.X = (10 * df) - df2;
            }
            else if ((20 < fnum) && (fnum <= 30))
            {
                Location.X = (fnum * df) - df2;
                Location.Y = (10*df) - df2;
            }
            else if ((30 < fnum) && (fnum <= 40))
            {
                Location.X = df2;
                Location.Y = (fnum * df) - df2;
            }
        }
        public void pay(int price)
        {
            money -= price;
        }
        public void get_money(int price)
        {
            money += price;
        }
    }
}
