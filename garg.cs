/* General Styling */
body {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    margin: 0;
    background: linear-gradient(135deg, #fbc2eb, #a6c1ee);
    font-family: 'Georgia', serif;
    color: #333;
}

/* Letter Container */
.letter-container {
    background: #fff;
    border: 2px solid #e57373;
    border-radius: 10px;
    padding: 20px;
    max-width: 400px;
    box-shadow: 0 8px 20px rgba(0, 0, 0, 0.2);
    position: relative;
    animation: float 2s infinite ease-in-out;
}

/* Float Animation */
@keyframes float {
    0%, 100% {
        transform: translateY(0);
    }
    50% {
        transform: translateY(-10px);
    }
}

/* Letter Text */
.title {
    text-align: center;
    color: #e57373;
    margin-bottom: 20px;
}

.message {
    font-size: 1rem;
    line-height: 1.8;
    text-align: left;
}

.signature {
    display: block;
    margin-top: 20px;
    text-align: right;
    font-style: italic;
    color: #e57373;
    font-weight: bold;
}

/* Responsive Styling */
@media (max-width: 500px) {
    .letter-container {
        padding: 15px;
        max-width: 90%;
    }
    .message {
        font-size: 0.9rem;
    }
}
