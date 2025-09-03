namespace MotivationalDays;

/* 4.
 * Un programa que utilice un enumerado de días y
 * dependiendo el día que indique el usuario imprima un mensaje motivador.
 */
public enum Day
{
	Lunes,
	Martes,
	Miercoles,
	Jueves,
	Viernes,
	Sabado,
	Domingo
}

public static class MotivationalMessage
{
	public static string GetMessage(Day day)
	{
		return day switch
		{
			Day.Lunes => "¡Nuevo inicio, nuevas oportunidades!",
			Day.Martes => "¡Sigue adelante con determinación!",
			Day.Miercoles => "¡Ya estás a mitad de semana!",
			Day.Jueves => "¡Casi llegamos al fin de semana!",
			Day.Viernes => "¡El esfuerzo de la semana está dando frutos!",
			Day.Sabado => "¡Disfruta y descansa!",
			Day.Domingo => "¡Recarga energías para la próxima semana!",
			_ => "¡Que tengas un excelente día!"
		};
	}
}
