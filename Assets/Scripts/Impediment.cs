public enum SIDES {
    BOTH,
    FIRST,
    SECOND, 
    NEITHER
}

public interface Impediment {
    abstract protected SIDES GetOpenSides();
    abstract protected SIDES GetClosedSides();
    abstract protected bool IsClosed();
}
