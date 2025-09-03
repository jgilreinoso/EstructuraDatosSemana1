namespace BookData;
using System;

/* 4. Un programa que almacene los datos de un libro,
 sabiendo que un libro tiene M páginas y que cada página 
tiene un máximo de N líneas y que cada línea puede tener P caracteres. 
Cree tres funciones que reciban el arreglo como parámetro: 
una que imprima una línea aleatoria de la primera página, 
otra de la página central y 
otra de la última página.
 */
public class Book
{
	private char[][][] pages; // [page][line][char]

	public Book(char[][][] pages)
	{
		this.pages = pages;
	}

	public string GetRandomLineFromFirstPage(Random? rng = null)
	{
	}

	public string GetRandomLineFromCentralPage(Random? rng = null)
	{
	}

	public string GetRandomLineFromLastPage(Random? rng = null)
	{
	}
}
