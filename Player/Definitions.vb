Public Class Definitions

    Public Enum AmmoType
        ArmourPiercing = 1
        Ball = 2
        Blank = 3
        Frangible = 4
        FullMetalJacket = 5
        Incendiary = 6
        Rubber = 7
        Tracer = 8
    End Enum

    Public Enum SoftDamageType
        PointTwoTwo = 1
        FivePointFiveSix
        SevenPointSixTwo
        NineMM
        ThreeOhEight
        ThreeOhOhWinchester
        FiftyCalibre
    End Enum

    Public Class Ammo

        Private m_Type As AmmoType
        Private m_SoftDamage As Short = 1

    End Class

End Class
