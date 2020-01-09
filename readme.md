![Trie illustration](Trie.png | width=400)
# TrieCS
Trie Class Library for C#. Support for word insertion and membership checking

## Usage
### Instantiation
Get an instance of Trie using either of the following constructors
```csharp
Trie trie = new Trie();
```
```csharp
string[] words = new string[] { "SOME", "WORDS", "HERE" };
Trie trie = new Trie(words);
```
```csharp
string filepath = @"path/to/dictionary/file"
Trie trie = new Trie(filepath);
```

### Word Insertion
You can add new words to the trie using the public Insert method.
```csharp
Trie trie = new Trie();
trie.Insert("HELLO");
trie.Insert("WORLD");
```

### Membership checking
You can use the public Contains method to check for membership (case-sensitive).
```csharp
Trie trie = new Trie();
Console.WriteLine("HELLO in Trie? {0}", trie.Contains("HELLO")); // False
Console.Insert("HELLO");
Console.WriteLine("HELLO in Trie? {0}", trie.Contains("HELLO")); // True
Console.WriteLine("HELLO in Trie? {0}", trie.Contains("hello")); // False because it is case-sensitive
```

## Additional information
More info on tries on [Wikipedia](https://en.wikipedia.org/wiki/Trie).
