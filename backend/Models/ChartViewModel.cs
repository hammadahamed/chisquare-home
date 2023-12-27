using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

public class FinancialData
{
    public int Id { get; set; }
    public string Type { get; set; }
    public string DataType { get; set; }

    [Column(TypeName = "jsonb")]
    public Dictionary<string, OverallData> Overall { get; set; }

    [Column(TypeName = "jsonb")]
    public Dictionary<string, MonthlyData> Monthly { get; set; }
}

public class MonthlyData
{
    public decimal CY { get; set; }
    public decimal PY { get; set; }
}

public class OverallData
{
    public decimal Value { get; set; }
    public string Unit { get; set; }
}
