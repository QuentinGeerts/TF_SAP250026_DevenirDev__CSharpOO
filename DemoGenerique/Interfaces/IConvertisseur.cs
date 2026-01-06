namespace DemoGenerique.Interfaces;

internal interface IConvertisseur<TEntree, TSortie>
{
    TSortie Convertir(TEntree valeur);
}
