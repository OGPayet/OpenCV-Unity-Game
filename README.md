# OpenCV-Unity-Game

### Téléchargement du jeu Unity

Le dossier du projet Unity étant trop volumineux pour être uploadé sur le github, voici le lien de téléchargement du projet :

https://uptobox.com/nw1sf22eensx

### Utilisation du script opencv

Il faut d'abord installer Miniconda3 :
https://docs.conda.io/en/latest/miniconda.html

Il faut ensuite créer un environnement virtuel avec conda :
```
conda create -y --name tensorflow python=3.7
```
Pour activer et utiliser l'environnement virtuel :
```
conda activate tensorflow
```

Une fois dans l'environnement virtuel, il faut installer les dépendances :
```
pip install -r requirements.txt
```

On peut maintenant lancer le script :
```
python real_time_gesture_detection.py
```

### Relier le jeu unity au script python

Il faut ajouter ces librairies au code du script joueur :
```
using System.Net;
using System.Net.Sockets;
using System.Threading;
```

Dans la class du joueur il faut ajouter ces variables :
```
Thread receiveThread;
UdpClient client;
int port;
```

Dans la fonction start() :
```
void Start() {
  port = 5065;
  InitUDP();
}
```

Il faut ajouter la fonction InitUDP() :
```
private void InitUDP()
{
  print("UDP Initialized");

  receiveThread = new Thread(new ThreadStart(ReceiveData));
  receiveThread.IsBackground = true;
  receiveThread.Start();
}
```

Puis ajouter la fonction ReceiveData() :
```
private void ReceiveData()
{
  client = new UdpClient(port);
  while (true)
  {
    try
    {
      IPEndPoint anyIP = new IPEndPoint(IPAddress.Parse("0.0.0.0"), port);
      byte[] data = client.Receive(ref anyIP);

      string text = Encoding.UTF8.GetString(data);
      print(">> " + text);
    }
    catch (Exception e)
    {
      print(e.ToString());
    }
  }
}
```
