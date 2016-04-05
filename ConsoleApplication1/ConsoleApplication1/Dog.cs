using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Trainer
    {
        void Operate()
        {
            var dog = new Poodle();
//
            dog.HasSpoken += Dog_HasSpoken;
        }

        private void Dog_HasSpoken(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }


    public partial class Dog
    {
        // criar uma variavel ou propriedade da calsse
        //propriedades hold values
        //sintaxe de formato compacto
        public string Name { get; set; }

        //full implementation das propriedades
        private int _myVar;

        public int Myvar
        {
            get { return _myVar; }

            //voce poder ler, mas n pode escrever
            // private set 
            set
            {
                //look at the value
                _myVar = value;
            }
        }

        public event EventHandler HasSpoken;

        // metodo pode ter passa um valor atraves de sua assinatura
        //o que o cachorro deve falar //string what
        public void Speak(string what = "bark" )
        {
            // TO DO
        }

        // nao pode ria ser  string what = "bark" , int time / porquequando voce declara valores default sao os ultimos
        public void Speak(int times, string what = "bark", bool sit = true)
        {
            // TO DO
            //aqui voce levanta o evento - forma padrao
            if (HasSpoken != null)
                HasSpoken(this, EventArgs.Empty);
        }


        //only by this class;
        private void Foo()
        {
        }
        //only this and derived classes
       // protected void Bar()
  
        //only in this assembly - Isso e um metodo
            internal void Bar() { }
    }

    class Poodle : Dog 
    {
        private void x()
        {
            this.Speak(2, "baraaa");
            this.Speak(3, sit:false);



        }
    }
}
