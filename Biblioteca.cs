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

        public Biblioteca(string nome, string indirizzo, string orarioApertura, string orarioChiusura)
        {
        }
        public Biblioteca(string nome, string indirizzo, string orarioApertura, string orarioChiusura, List<Libro> libri) : this(nome,indirizzo, orarioApertura, orarioChiusura)
        {
        }

        public int NumeroLibri() => Libri.Count;

        public List<Libro> LibriDellAutore(string nomeAutore)
        {
        }

        public List<Libro> CercaLibriConTitolo(string titolo)
        {
        }

        public void AggiungiLibro(Libro libro)
        {
        }
    }
}
