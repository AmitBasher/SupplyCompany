namespace SupplyCompany.Domain;
public class Object1Id { // Id Object
    public Guid Value { get; set; }
}
public class Object2Id { // Id Object
    public Guid Value { get; set; }
}
public class Object1 { //Object to Hold Few Object2
    public Object1Id Id { get; set; }
    List<Object2> list { get; set; }
}
public class Object2 { //An Independent Object
    public Object2Id Id { get; set; }
    public string Something { get; set; }
}

public class Object1_Object2 {//Relation Many-Many For DB
    public Object1Id Object1Id { get; set; }
    public Object2Id Object2Id { get; set; }
}
