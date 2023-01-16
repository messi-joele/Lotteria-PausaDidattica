using quadro.libreria;
namespace testGhilardi
{
    public class UnitTest1
    {
        [Fact]
        public void Test()
        {
            

            [Fact]
            void Test1()
            {
                Quadro quadro = new Quadro("Giotto", 75, 246, 324, 750);
                Quadro quadro2 = new Quadro("Leonardo", 45, 124, 300, 450);
                Assert.False(quadro.Equals(quadro2));
            }

            [Fact]
            void Test2()
            {
                Quadro quadro = new Quadro("Giotto", 75, 246, 324, 750);
                Quadro quadro2 = new Quadro("Leonardo", 45, 124, 300, 450);
                float a = quadro.Altezza;

                quadro.ModDati(5, 3, 1, 3);

                Assert.False(quadro.Altezza == a);

            }
            [Fact]
            void Test3()
            {
                Quadro quadro = new Quadro("Giotto", 75, 246, 324, 750);
                Quadro quadro2 = new Quadro("Leonardo", 45, 124, 300, 450);
                float a = quadro.Lunghezza;

                quadro.ModDati(5, 3, 1, 3);

                Assert.False(quadro.Lunghezza == a);
            }
            [Fact]
            void Test4()
            {
                Quadro quadro = new Quadro("Giotto", 75, 246, 324, 750);
                Quadro quadro2 = new Quadro("Lonardo", 45, 124, 300, 450);
                float a = quadro.PrezzoOff;

                quadro.ModDati(5, 3, 1, 3);

                Assert.False(quadro.PrezzoOff == a);
            }
            [Fact]
            void Test5()
            {
                Quadro quadro = new Quadro("Giotto", 75, 246, 324, 750);
                Quadro quadro2 = new Quadro("Leonardo", 45, 124, 300, 450);
                float a = quadro.PrezzoTras;

                quadro.ModDati(5, 3, 1, 3);

                Assert.False(quadro.PrezzoTras == a);
            }
            [Fact]
            void Test6()
            {
                Quadro quadro = new Quadro("Giotto", 75, 246, 324, 750);
                Quadro quadro2 = new Quadro("Leonado", 45, 124, 300, 450);

                Quadro a = quadro;
                Quadro b = quadro2;
                quadro.Confronta(a, b);

                Assert.True(a.PrezzoOff > b.PrezzoOff);
            }
            [Fact]
            void Test7()
            {
                Quadro quadro = new Quadro("Giotto", 75, 246, 324, 750);
                Quadro quadro2 = new Quadro("Leonardo", 75, 246, 324, 750);

                Quadro a = quadro;
                Quadro b = quadro2;
                quadro.Confronta(a, b);

                Assert.True(a.PrezzoOff == b.PrezzoOff);
            }

            [Fact]
            void Test8()
            {
                Quadro quadro = new Quadro("Giotto", 75, 246, 324, 750);
                Quadro quadro2 = new Quadro("Lonardo", 45, 124, 300, 450);

                float a = quadro.PrezzoOff + 100;

                quadro.Offerta(a);

                Assert.False(a > quadro.PrezzoOff);
                //da eccezione quindi funziona
            }
            [Fact]
            void Test9()
            {
                Quadro quadro = new Quadro("Giotto", 75, 246, 324, 750);
                Quadro quadro2 = new Quadro("Leonardo", 45, 124, 300, 450);

                float a = quadro.PrezzoOff - 10;

                quadro.Offerta(a);

                Assert.True(a > quadro.PrezzoOff);
                //da eccezione quindi funziona
            }

            [Fact]

            void Test10()
            {
                Quadro quadro = new Quadro("Giotto", 75, 246, 324, 750);
                Quadro quadro2 = new Quadro("Leonardo", 45, 124, 300, 450);

                quadro.Trasporto();
                Assert.True(quadro.RichiediTras == true);
            }
            [Fact]
            void Test11()
            {
                Quadro quadro = new Quadro("Giotto", 75, 246, 324, 750);

                string a = Convert.ToString(quadro.PrezzoOff);

                Assert.True(quadro.Ultimaoff() == a);
            }
            [Fact]
            void Test12()
            {
                Quadro quadro = new Quadro("Giotto", 75, 246, 324, 750);
                float a = quadro.PrezzoOff + quadro.PrezzoTras;
                string b = Convert.ToString(a);

                Assert.True(quadro.Prezzofin() == b);
            }
        }
    }
}