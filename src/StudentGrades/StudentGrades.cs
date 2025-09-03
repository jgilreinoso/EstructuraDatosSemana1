using System.Text;

namespace StudentGrades;

public class StudentGrades
{
    /*3. Un programa que almacene, en un arreglo multidimensional,
     * las calificaciones del examen final y los dos parciales
     * para N estudiantes
     * y luego imprima dichos datos junto con el promedio.
     */
    private double[,] grades;
	public StudentGrades(double[,] grades)
	{
		this.grades = grades;
	}

	public string GetAllGradesWithAverages()
	{
		StringBuilder output = new StringBuilder();
        //TODO: Recorrer el arreglo e implementar una salida que cumpla con los requisitos. E.J.: Estudiante 1: Final=100, Parcial1=100, Parcial2=100, Promedio=100.00
        
        return output.ToString();
	}
}
