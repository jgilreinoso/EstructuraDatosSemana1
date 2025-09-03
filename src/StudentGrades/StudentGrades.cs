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
        int students = grades.GetLength(0);
        int subjects = grades.GetLength(1);
        
        for (int i = 0; i < students; i++)
        {
            double final = grades[i, 0];
            double parcial1 = grades[i, 1];
            double parcial2 = grades[i, 2];
            double promedio = (final + parcial1 + parcial2) / 3.0;
            
            output.Append($"Estudiante {i + 1}: Final={final}, Parcial1={parcial1}, Parcial2={parcial2}, Promedio={promedio:F2}\r\n");
        }
        
        return output.ToString();
	}
}
