using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaScolastica
{
    class Libro
    {
        string _autore;
        string _titolo;
        string _editore;
        int _annoPubblicazione;
        int _nPagine;

        public string Autore
        {
            get { return _autore; }
            set { _autore = value; }
        }
        public string Titolo
        {
            get { return _titolo; }
            set { _titolo = value; }
        }
        public string Editore
        {
            get { return _editore; }
            set { _editore = value; }
        }
        public int AnnoPubblicazione
        {
            get { return _annoPubblicazione; }
            set
            {
                if (value < DateTime.Now.Year)
                    _annoPubblicazione = value;
                else
                    throw new Exception("anno non valido");
            }
        }
        public int NPagine
        {
            get { return _nPagine; }
            set
            {
                if (value > 0) _nPagine = value;
                else throw new Exception("non possono esserci meno di 0 pagine");
            }
        }

        public Libro(string autore, string titolo, string editore, int anno, int nPagine)
        {
            Autore = autore;
            Titolo = titolo;
            Editore = editore;
            AnnoPubblicazione = anno;
            NPagine = nPagine;
        }


        public string ReadingTime()
        {
            if (NPagine < 100)
                return "1h";
            else if (NPagine > 200)
                return "2h+";
            else
                return "2h";
        }


        public override string ToString()
        {
            return $"[{AnnoPubblicazione}] {Titolo} (di {Autore}, editore: {Editore}) - {NPagine} pagine";
        }
    }
}
