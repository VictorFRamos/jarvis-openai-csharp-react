import { useState } from "react";
import axios from "axios";

function App() {
  const [message, setMessage] = useState("");
  const [chat, setChat] = useState([]);

  const sendMessage = async () => {
    if (!message) return;

    const userMsg = { role: "user", text: message };
    setChat(prev => [...prev, userMsg]);

    const res = await axios.post("http://localhost:5000/api/chat", {
      message
    });

    const botMsg = { role: "bot", text: res.data.response };

    setChat(prev => [...prev, botMsg]);
    setMessage("");
  };

  return (
    <div style={{ padding: 20 }}>
      <h1>Jarvis 🤖</h1>

      <div style={{ marginBottom: 20 }}>
        {chat.map((c, i) => (
          <div key={i}>
            <strong>{c.role}:</strong> {c.text}
          </div>
        ))}
      </div>

      <input
        value={message}
        onChange={(e) => setMessage(e.target.value)}
        placeholder="Digite sua mensagem..."
      />

      <button onClick={sendMessage}>Enviar</button>
    </div>
  );
}

export default App;