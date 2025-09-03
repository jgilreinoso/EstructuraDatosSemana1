namespace ParityChecker;

public class ParityChecker
{
    /* 1.
	 * Un programa que determine si el número de matrícula de un estudiante es par o impar.
	 */
    public static bool IsEven(int studentId)
	{
		return studentId % 2 == 0;
	}
}
