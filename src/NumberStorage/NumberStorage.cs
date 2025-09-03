namespace NumberStorage;

/* 2.
 * Un programa que almacene una serie de números enteros en un arreglo
 * y permita al usuario consultar el número almacenado en una posición específica del arreglo.
 */
public class NumberStorage
{
	private int[] numbers;

	public NumberStorage(int[] numbers)
	{
		this.numbers = numbers;
	}

	public int GetNumberAt(int index)
	{
		if (index < 0 || index >= numbers.Length)
		{
			throw new IndexOutOfRangeException();
		}
		return numbers[index];
	}
}
