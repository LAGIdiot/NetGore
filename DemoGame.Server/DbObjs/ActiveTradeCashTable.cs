/********************************************************************
                   DO NOT MANUALLY EDIT THIS FILE!

This file was automatically generated using the DbClassCreator
program. The only time you should ever alter this file is if you are
using an automated code formatter. The DbClassCreator will overwrite
this file every time it is run, so all manual changes will be lost.
If there is something in this file that you wish to change, you should
be able to do it through the DbClassCreator arguments.

Make sure that you re-run the DbClassCreator every time you alter your
game's database.

For more information on the DbClassCreator, please see:
    http://www.netgore.com/wiki/DbClassCreator
********************************************************************/

using System;
using System.Linq;
using NetGore;
using NetGore.IO;
using System.Collections.Generic;
using System.Collections;
using NetGore.Db;
using DemoGame.DbObjs;
namespace DemoGame.Server.DbObjs
{
/// <summary>
/// Provides a strongly-typed structure for the database table `active_trade_cash`.
/// </summary>
public class ActiveTradeCashTable : IActiveTradeCashTable, NetGore.IO.IPersistable
{
/// <summary>
/// Array of the database column names.
/// </summary>
 static  readonly System.String[] _dbColumns = new string[] {"cash", "character_id" };
/// <summary>
/// Gets an IEnumerable of strings containing the names of the database columns for the table that this class represents.
/// </summary>
public static System.Collections.Generic.IEnumerable<System.String> DbColumns
{
get
{
return (System.Collections.Generic.IEnumerable<System.String>)_dbColumns;
}
}
/// <summary>
/// Array of the database column names for columns that are primary keys.
/// </summary>
 static  readonly System.String[] _dbColumnsKeys = new string[] {"character_id" };
/// <summary>
/// Gets an IEnumerable of strings containing the names of the database columns that are primary keys.
/// </summary>
public static System.Collections.Generic.IEnumerable<System.String> DbKeyColumns
{
get
{
return (System.Collections.Generic.IEnumerable<System.String>)_dbColumnsKeys;
}
}
/// <summary>
/// Array of the database column names for columns that are not primary keys.
/// </summary>
 static  readonly System.String[] _dbColumnsNonKey = new string[] {"cash" };
/// <summary>
/// Gets an IEnumerable of strings containing the names of the database columns that are not primary keys.
/// </summary>
public static System.Collections.Generic.IEnumerable<System.String> DbNonKeyColumns
{
get
{
return (System.Collections.Generic.IEnumerable<System.String>)_dbColumnsNonKey;
}
}
/// <summary>
/// The name of the database table that this class represents.
/// </summary>
public const System.String TableName = "active_trade_cash";
/// <summary>
/// The number of columns in the database table that this class represents.
/// </summary>
public const System.Int32 ColumnCount = 2;
/// <summary>
/// The field that maps onto the database column `cash`.
/// </summary>
System.Int32 _cash;
/// <summary>
/// The field that maps onto the database column `character_id`.
/// </summary>
System.Int32 _characterID;
/// <summary>
/// Gets or sets the value for the field that maps onto the database column `cash`.
/// The underlying database type is `int(11)`.The database column contains the comment: 
/// "The amount of cash the character put down.".
/// </summary>
[System.ComponentModel.Description("The amount of cash the character put down.")]
[NetGore.SyncValueAttribute()]
public System.Int32 Cash
{
get
{
return (System.Int32)_cash;
}
set
{
this._cash = (System.Int32)value;
}
}
/// <summary>
/// Gets or sets the value for the field that maps onto the database column `character_id`.
/// The underlying database type is `int(11)`.The database column contains the comment: 
/// "The character that put the cash on the trade table.".
/// </summary>
[System.ComponentModel.Description("The character that put the cash on the trade table.")]
[NetGore.SyncValueAttribute()]
public DemoGame.CharacterID CharacterID
{
get
{
return (DemoGame.CharacterID)_characterID;
}
set
{
this._characterID = (System.Int32)value;
}
}

/// <summary>
/// Creates a deep copy of this table. All the values will be the same
/// but they will be contained in a different object instance.
/// </summary>
/// <returns>
/// A deep copy of this table.
/// </returns>
public virtual IActiveTradeCashTable DeepCopy()
{
return new ActiveTradeCashTable(this);
}
/// <summary>
/// Initializes a new instance of the <see cref="ActiveTradeCashTable"/> class.
/// </summary>
public ActiveTradeCashTable()
{
}
/// <summary>
/// Initializes a new instance of the <see cref="ActiveTradeCashTable"/> class.
/// </summary>
/// <param name="cash">The initial value for the corresponding property.</param>
/// <param name="characterID">The initial value for the corresponding property.</param>
public ActiveTradeCashTable(System.Int32 @cash, DemoGame.CharacterID @characterID)
{
this.Cash = (System.Int32)@cash;
this.CharacterID = (DemoGame.CharacterID)@characterID;
}
/// <summary>
/// Initializes a new instance of the <see cref="ActiveTradeCashTable"/> class.
/// </summary>
/// <param name="source">IActiveTradeCashTable to copy the initial values from.</param>
public ActiveTradeCashTable(IActiveTradeCashTable source)
{
CopyValuesFrom(source);
}
/// <summary>
/// Copies the column values into the given Dictionary using the database column name
/// with a prefixed @ as the key. The keys must already exist in the Dictionary;
/// this method will not create them if they are missing.
/// </summary>
/// <param name="dic">The Dictionary to copy the values into.</param>
public void CopyValues(System.Collections.Generic.IDictionary<System.String,System.Object> dic)
{
CopyValues(this, dic);
}
/// <summary>
/// Copies the column values into the given Dictionary using the database column name
/// with a prefixed @ as the key. The keys must already exist in the Dictionary;
/// this method will not create them if they are missing.
/// </summary>
/// <param name="source">The object to copy the values from.</param>
/// <param name="dic">The Dictionary to copy the values into.</param>
public static void CopyValues(IActiveTradeCashTable source, System.Collections.Generic.IDictionary<System.String,System.Object> dic)
{
dic["cash"] = (System.Int32)source.Cash;
dic["character_id"] = (DemoGame.CharacterID)source.CharacterID;
}

/// <summary>
/// Copies the values from the given <paramref name="source"/> into this ActiveTradeCashTable.
/// </summary>
/// <param name="source">The IActiveTradeCashTable to copy the values from.</param>
public void CopyValuesFrom(IActiveTradeCashTable source)
{
this.Cash = (System.Int32)source.Cash;
this.CharacterID = (DemoGame.CharacterID)source.CharacterID;
}

/// <summary>
/// Gets the value of a column by the database column's name.
/// </summary>
/// <param name="columnName">The database name of the column to get the value for.</param>
/// <returns>
/// The value of the column with the name <paramref name="columnName"/>.
/// </returns>
public System.Object GetValue(System.String columnName)
{
switch (columnName)
{
case "cash":
return Cash;

case "character_id":
return CharacterID;

default:
throw new ArgumentException("Field not found.","columnName");
}
}

/// <summary>
/// Sets the <paramref name="value"/> of a column by the database column's name.
/// </summary>
/// <param name="columnName">The database name of the column to get the <paramref name="value"/> for.</param>
/// <param name="value">Value to assign to the column.</param>
public void SetValue(System.String columnName, System.Object value)
{
switch (columnName)
{
case "cash":
this.Cash = (System.Int32)value;
break;

case "character_id":
this.CharacterID = (DemoGame.CharacterID)value;
break;

default:
throw new ArgumentException("Field not found.","columnName");
}
}

/// <summary>
/// Gets the data for the database column that this table represents.
/// </summary>
/// <param name="columnName">The database name of the column to get the data for.</param>
/// <returns>
/// The data for the database column with the name <paramref name="columnName"/>.
/// </returns>
public static ColumnMetadata GetColumnData(System.String columnName)
{
switch (columnName)
{
case "cash":
return new ColumnMetadata("cash", "The amount of cash the character put down.", "int(11)", null, typeof(System.Int32), false, false, false);

case "character_id":
return new ColumnMetadata("character_id", "The character that put the cash on the trade table.", "int(11)", null, typeof(System.Int32), false, true, false);

default:
throw new ArgumentException("Field not found.","columnName");
}
}

/// <summary>
/// Reads the state of the object from an <see cref="IValueReader"/>.
/// </summary>
/// <param name="reader">The <see cref="IValueReader"/> to read the values from.</param>
public virtual void ReadState(NetGore.IO.IValueReader reader)
{
NetGore.IO.PersistableHelper.Read(this, reader);
}

/// <summary>
/// Writes the state of the object to an <see cref="IValueWriter"/>.
/// </summary>
/// <param name="writer">The <see cref="IValueWriter"/> to write the values to.</param>
public virtual void WriteState(NetGore.IO.IValueWriter writer)
{
NetGore.IO.PersistableHelper.Write(this, writer);
}

}

}
