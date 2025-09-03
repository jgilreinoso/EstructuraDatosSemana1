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
		rng ??= new Random();
		
		if (pages.Length == 0 || pages[0].Length == 0)
			return string.Empty;
			
		int randomLineIndex = rng.Next(pages[0].Length);
		return new string(pages[0][randomLineIndex]);
	}

	public string GetRandomLineFromCentralPage(Random? rng = null)
	{
		rng ??= new Random();
		
		if (pages.Length == 0)
			return string.Empty;
			
		int centralPageIndex = pages.Length / 2;
		if (pages[centralPageIndex].Length == 0)
			return string.Empty;
			
		int randomLineIndex = rng.Next(pages[centralPageIndex].Length);
		return new string(pages[centralPageIndex][randomLineIndex]);
	}

	public string GetRandomLineFromLastPage(Random? rng = null)
	{
		rng ??= new Random();
		
		if (pages.Length == 0 || pages[pages.Length - 1].Length == 0)
			return string.Empty;
			
		int lastPageIndex = pages.Length - 1;
		int randomLineIndex = rng.Next(pages[lastPageIndex].Length);
		return new string(pages[lastPageIndex][randomLineIndex]);
	}
}
