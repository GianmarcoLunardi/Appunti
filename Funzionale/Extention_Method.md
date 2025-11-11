# Metodi di Estensione in C#
I metodi di estensione (Extension Methods) in C# sono una funzionalità che permette di "aggiungere" nuovi metodi a tipi esistenti senza doverli modificare o ereditare

```
public class AccountState
{
  public decimal Balance { get; }
  public AccountState(decimal balance) { Balance = balance; }
}


public static class Account
  {
  public static Option<AccountState> Debit (this AccountState acc, decimal amount)
  => (acc.Balance < amount) ? None : Some(new AccountState(acc.Balance - amount));
  }
```
I metodi di estensione sono definiti come metodi statici in una classe statica.
Il primo parametro del metodo di estensione deve essere preceduto dalla parola chiave this, che indica a quale tipo si applica il metodo.
Possono essere utilizzati come se fossero metodi istanza del tipo a cui si applicano.
