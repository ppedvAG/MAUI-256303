namespace M008;

internal class EnumExtension : IMarkupExtension
{
	public Type EnumType { get; set; }

	/// <summary>
	/// Wenn die GUI den Wert benötigt, wird diese Methode ausgeführt
	/// Der Rückgabewert dieser Methode, wird dann in der GUI eingesetzt
	/// </summary>
	public object ProvideValue(IServiceProvider serviceProvider)
	{
		ArgumentNullException.ThrowIfNull("EnumType darf nicht null sein", nameof(EnumType));

		if (!EnumType.IsEnum)
			throw new ArgumentException("EnumType ist kein Enum Typ");

		return Enum.GetValues(EnumType);
	}
}
