# Gestionale Pazienti - Progetto in C#

Questo progetto è un'applicazione di gestione per i pazienti, che consente di aggiungere e visualizzare pazienti e i loro piani terapeutici. L'interfaccia utente è costruita con **Windows Forms** in C#, ed è progettato per essere utilizzato in contesti sanitari, come cliniche o ospedali, per la gestione dei dati dei pazienti.

## Indice

- [Tecnologie](#tecnologie)
- [Funzionalità](#funzionalità)
- [Struttura del Progetto](#struttura-del-progetto)
- [Come Iniziare](#come-iniziare)
- [Gestione Dati](#gestione-dati)
- [Caricamento e Salvataggio dei Dati](#caricamento-e-salvataggio-dei-dati)
- [Autori e Licenza](#autori-e-licenza)

## Tecnologie

Il progetto è sviluppato utilizzando le seguenti tecnologie:

- **C#** come linguaggio di programmazione
- **Windows Forms** per l'interfaccia utente
- **JSON** per il salvataggio dei dati
- **Newtonsoft.Json** per la serializzazione/deserializzazione dei dati JSON

## Funzionalità

Il progetto offre le seguenti funzionalità principali:

- **Visualizzazione Pazienti**: mostra tutti i pazienti e i loro piani terapeutici in una tabella.
- **Aggiunta di Pazienti e Piani Terapeutici**: consente di aggiungere nuovi pazienti, specificando il nome, cognome, codice fiscale, data di nascita, e i piani terapeutici con i relativi farmaci e date di inizio e fine.
- **Persistenza dei Dati**: i dati relativi ai pazienti e ai loro piani terapeutici vengono salvati in un file JSON per la persistenza.
- **Visualizzazione Pianificata**: ogni paziente viene mostrato una sola volta con il nome, cognome e codice fiscale, mentre i piani terapeutici vengono mostrati sotto la stessa voce, per evitare ripetizioni.

## Struttura del Progetto

Il progetto è organizzato come segue:

GestionaleUI
├── FrontEnd.
│ ├── StampaPazienti.cs # Interfaccia per visualizzare i pazienti e i loro piani.
│ ├── AggiungiPazienti.cs # Interfaccia per aggiungere pazienti e piani.
├── BackEnd.
│ ├── Paziente.cs # Modello di un paziente.
│ ├── PianoTerapeutico.cs # Modello di un piano terapeutico.
│ ├── PazienteStore.cs # Gestione dei dati e salvataggio su file.
├── Data.
│ └── pazienti.json # File JSON che contiene i dati dei pazienti.
└── GestionaleUI.sln # Solution del progetto.


## Come Iniziare

1. **Clona il repository**: per iniziare, clona il repository sulla tua macchina locale.
   
   ```bash
   git clone https://github.com/tuo-utente/tuo-repository.git
Apri il progetto: apri il file GestionaleUI.sln con Visual Studio.

Compila e Esegui: costruisci e avvia il progetto utilizzando Visual Studio.

Per aggiungere nuovi pazienti, vai alla sezione Aggiungi Pazienti, inserisci i dati e clicca su "Aggiungi".

Per visualizzare i pazienti, vai alla sezione Stampa Pazienti, dove vedrai la lista dei pazienti e i loro piani terapeutici.

Gestione Dati
Modelli
Nel progetto, i dati sono organizzati in due modelli principali:

Paziente: rappresenta un singolo paziente con le seguenti proprietà:

Nome: nome del paziente.

Cognome: cognome del paziente.

CodiceFiscale: codice fiscale del paziente.

DataNascita: data di nascita del paziente.

Piani: lista di piani terapeutici associati al paziente.

Piano Terapeutico: rappresenta un piano terapeutico per un paziente, con le seguenti proprietà:

Farmaco: nome del farmaco somministrato.

Inizio: data di inizio del piano terapeutico.

Fine: data di fine del piano terapeutico.

Salvataggio e Caricamento dei Dati
I dati dei pazienti e dei loro piani terapeutici sono memorizzati in un file JSON denominato pazienti.json che si trova nella cartella Data. Utilizzando la libreria Newtonsoft.Json, i dati sono serializzati e deserializzati per la persistenza.

Salvataggio: i dati vengono salvati nel file JSON ogni volta che un nuovo paziente o piano viene aggiunto.

Caricamento: all'avvio dell'applicazione, i dati vengono caricati automaticamente dal file JSON per essere visualizzati nell'interfaccia utente.

File JSON
Ecco un esempio di come appare il file pazienti.json:

[
  {
    "Nome": "Marco",
    "Cognome": "Rossi",
    "CodiceFiscale": "RSSMRC85A01H501Z",
    "DataNascita": "1985-01-01T00:00:00",
    "Piani": [
      {
        "Farmaco": "Farmaco A",
        "Inizio": "2025-05-01T00:00:00",
        "Fine": "2025-11-01T00:00:00"
      },
      {
        "Farmaco": "Farmaco B",
        "Inizio": "2025-06-01T00:00:00",
        "Fine": "2025-12-01T00:00:00"
      }
    ]
  }
]
