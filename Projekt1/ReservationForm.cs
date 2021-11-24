using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
//using System.Timers;

namespace Projekt1
{
    public partial class ReservationForm : Form
    {
        System.Timers.Timer timer = new System.Timers.Timer(1000);
        private List<Movie> movies;
        private Movie movie_selected;
        private List<Rezervation> rezervations;
        private List<int> seats = new List<int>();
        private List<string> taken = new List<string>();
        //private int idMovie;

        public ReservationForm()
        {
            InitializeComponent();

            Cinema_DB cinema = new Cinema_DB();
            movies = cinema.read_Movies();
            movieComboBox.Items.Clear();
            foreach (Movie movie in movies)
            {
                movieComboBox.Items.Add(movie.id + "         " + movie.title + " " + movie.date.Substring(0, 10).ToString() + " " + movie.time.Substring(10));// " " + movie.date.ToString() +
            }

            
            timer.Elapsed += Timer_Elapsed;
            timer.Stop();
            timer.Dispose();
            timer = new System.Timers.Timer(10000);
            timer.Start();

            // green - avaible
            // gray - not avaible
            // orange - your choice

            // Tu wczytujemy zajętość 
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.BackColor = Color.Green;
            }
            button16.BackColor = Color.Gray;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("XD");
            timer.Stop();
            button16.BackColor = Color.Gray;

            foreach(string t in taken)
            {
                Console.WriteLine(t);
                button_Click(t);
            }
            taken.Clear();
            button16.BackColor = Color.Gray;
        }

        private void button_Click(string which)
        {

            timer.Stop();
            timer.Dispose();
            timer = new System.Timers.Timer(5000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();


            Button button = new Button();

            //progressBar1.Value = 900;

            if (which == "1")
            {
                button = button1;
            }
            else if (which == "2")
            {
                button = button2;
            }
            else if (which == "3")
            {
                button = button3;
            }
            else if (which == "4")
            {
                button = button4;
            }
            else if (which == "5")
            {
                button = button5;
            }
            else if (which == "6")
            {
                button = button6;
            }
            else if (which == "7")
            {
                button = button7;
            }
            else if (which == "8")
            {
                button = button8;
            }
            else if (which == "9")
            {
                button = button9;
            }
            else if (which == "10")
            {
                button = button10;
            }
            else if (which == "11")
            {
                button = button11;
            }
            else if (which == "12")
            {
                button = button12;
            }
            else if (which == "13")
            {
                button = button13;
            }
            else if (which == "14")
            {
                button = button14;
            }
            else if (which == "15")
            {
                button = button15;
            }

            if (button.BackColor == Color.Gray)
            {
                button.BackColor = Color.Gray;
            }
            else if (button.BackColor == Color.Green)
            {
                button.BackColor = Color.Orange;
                Console.WriteLine(which);
                taken.Add(which);
                Cinema_DB cinema = new Cinema_DB();
                Rezervation rezervation = new Rezervation();
                rezervation.movie = movie_selected.id;
                rezervation.place = Int32.Parse(which);
                Console.WriteLine(rezervation.place);
                rezervation.user = Int32.Parse(label1.Text);
                Console.WriteLine(rezervation.user);

                cinema.add_rezervation(rezervation);

                // add_rezervation
            }
            else if (button.BackColor == Color.Orange)
            {
                button.BackColor = Color.Green;

                Cinema_DB cinema = new Cinema_DB();
                Rezervation rezervation = new Rezervation();
                rezervation.movie = movie_selected.id;
                rezervation.place = Int32.Parse(which);
                Console.WriteLine(rezervation.place);
                rezervation.user = Int32.Parse(label1.Text);
                Console.WriteLine(rezervation.user);

                int id_to_delete = new int();

                foreach(Rezervation rez in rezervations)
                {
                    Console.WriteLine
                        (
                        rez.movie == movie_selected.id &&
                        rez.place == Int32.Parse(which) &&
                        rez.user == Int32.Parse(label1.Text)
                        );

                    if (
                        rez.movie == movie_selected.id &&
                        rez.place == Int32.Parse(which) &&
                        rez.user == Int32.Parse(label1.Text))
                    {
                        id_to_delete = rez.id;
                        Console.WriteLine("To delete:");
                        Console.WriteLine(id_to_delete);
                    }
                }

                cinema.delete_Rezervation(id_to_delete);
                //find_rezervation_by_Movie()


                taken.Remove(which);
            }

            if (button16.BackColor == Color.Gray)
            {
                button16.BackColor = Color.Red;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            button_Click("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_Click("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_Click("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_Click("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_Click("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_Click("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_Click("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_Click("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_Click("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button_Click("10");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button_Click("11");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button_Click("12");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button_Click("13");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button_Click("14");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button_Click("15");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button_Click("16");

            timer.Stop();


            if (button16.BackColor == Color.Red) 
            {
                button16.BackColor = Color.Gray;
            }
        }
    
        private void movieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer.Dispose();
            seats = new List<int>();
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.BackColor = Color.Green;
            }
            button16.BackColor = Color.Gray;

            movieComboBox.SelectedItem = sender.ToString();
            Cinema_DB cinema = new Cinema_DB();
            //Rezervation rezervation = new Rezervation();
            rezervations = cinema.read_Rezervation();
            int k = movieComboBox.SelectedIndex + 1;
            Console.WriteLine("k: " + k.ToString());

            movie_selected = cinema.find_movie(k);

            foreach (Rezervation rezervation in rezervations)
            {
                if(rezervation.movie == k)
                {
                    seats.Add(rezervation.place);
                }
                movie_selected = cinema.find_movie(rezervation.movie);
            }

            foreach(int el in seats)
            {
                seat_taken(el);
            }


        }

        private void seat_taken(int which)
        {
            Button button = new Button();

            //progressBar1.Value = 900;

            if (which == 1)
            {
                button = button1;
            }
            else if (which == 2)
            {
                button = button2;
            }
            else if (which == 3)
            {
                button = button3;
            }
            else if (which == 4)
            {
                button = button4;
            }
            else if (which == 5)
            {
                button = button5;
            }
            else if (which == 6)
            {
                button = button6;
            }
            else if (which == 7)
            {
                button = button7;
            }
            else if (which == 8)
            {
                button = button8;
            }
            else if (which == 9)
            {
                button = button9;
            }
            else if (which == 10)
            {
                button = button10;
            }
            else if (which == 11)
            {
                button = button11;
            }
            else if (which == 12)
            {
                button = button12;
            }
            else if (which == 13)
            {
                button = button13;
            }
            else if (which == 14)
            {
                button = button14;
            }
            else if (which == 15)
            {
                button = button15;
            }

            button.BackColor = Color.Gray;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void user_number(int i)
        {
            label1.Text = i.ToString();
        }
    }
}
