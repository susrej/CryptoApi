CryptoApi är ett enkelt C# Web API för kryptering och avkryptering.
Projektet använder Git Flow och GitHub Actions för CI/CD och är konfigurerat för automatisk distribution till AWS Elastic Beanstalk.

Det finns ingen frontend i projektet — interaktion sker via API-endpoints (t.ex. med Postman eller curl).

🚀 Kom igång
1. Klona repot
git clone https://github.com/susrej/CryptoApi.git
cd CryptoApi

2. Kör API lokalt
dotnet run

API:t kommer att vara tillgängligt på:
http://cryptoapi-env.eba-yseebhrq.eu-north-1.elasticbeanstalk.com/

🔒 POST /encryption/encrypt
Används för att kryptera text.
Exempel: /encryption/encrypt?text=Hello&shift=3

🔓 POST /encryption/decrypt
Används för att avkryptera text.
Exempel: /encryption/decrypt?text=Khoor&shift=3

🌲 Git Flow
Projektet använder Git Flow-strategi:
feature/* – nya funktioner
development – samlad utveckling och testning
main – stabil produktionskod
hotfix/* – snabba felrättningar

🔁 CI/CD med GitHub Actions
När körs vad?

✔ Push/PR till feature – automatiska tester (CI)
✔ Merge till development – build + tester
✔ Merge till main – build, tester och deployment till AWS Elastic Beanstalk (CD)

☁️ Distribution (Deployment)

När kod mergas till main:

📌 GitHub Actions bygger projektet
📌 Tester körs automatiskt
📌 API deployas till AWS Elastic Beanstalk

Din backend är då tillgänglig på Elastic Beanstalk-URL:en.

📦 Tekniker

C# / .NET API
Git + GitHub
GitHub Actions (CI/CD)
AWS Elastic Beanstalk
