using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaScolastica
{
    public class Biblioteca
    {
        string _nome;
        string _indirizzo;
        string _orarioApertura;
        string _orarioChiusura;

        List<Libro> _libri;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Indirizzo
        {
            get { return _indirizzo; }
            set { _indirizzo = value; }
        }
        public string OrarioApertura
        {
            get { return _orarioApertura; }
            set { _orarioApertura = value; }
        }
        public string OrarioChiusura
        {
            get { return _orarioChiusura; }
            set { _orarioChiusura = value; }
        }

        public List<Libro> Libri
        {
            get { return _libri; }
            private set { _libri = value; }
        }

        public Biblioteca(string nome, string indirizzo, string orarioApertura, string orarioChiusura)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            OrarioApertura = orarioApertura;
            OrarioChiusura = orarioChiusura;

            Libri = new List<Libro>();
        }
        public Biblioteca(string nome, string indirizzo, string orarioApertura, string orarioChiusura, List<Libro> libri) : this(nome, indirizzo, orarioApertura, orarioChiusura)
        {
            foreach (Libro l in libri)
                AggiungiLibro(l);
        }

        public int NumeroLibri() => Libri.Count;

        public List<Libro> LibriDellAutore(string nomeAutore)
        {
            List<Libro> libriTrovati = new List<Libro>();
            nomeAutore = nomeAutore.ToLower();

            foreach (Libro l in Libri)
                if (l.Autore.ToLower() == nomeAutore)
                    libriTrovati.Add(l);

            return libriTrovati;
        }

        public List<Libro> CercaLibriConTitolo(string titolo)
        {
            List<Libro> libriTrovati = new List<Libro>();
            titolo = titolo.ToLower();

            foreach (Libro l in Libri)
                if (l.Titolo.ToLower().Contains(titolo))
                    libriTrovati.Add(l);

            return libriTrovati;
        }

        public void AggiungiLibro(string autore, string titolo, string editore, int anno, int nPagine)
        {
            AggiungiLibro(new Libro(autore, titolo, editore, anno, nPagine));
        }
        public void AggiungiLibro(Libro libro)
        {
            Libri.Add(libro);
        }
    }
}
