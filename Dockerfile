FROM rust:latest

# Install Node.js
RUN curl -fsSL https://deb.nodesource.com/setup_18.x | bash - && \
    apt-get install -y nodejs

# Install wasm-pack for WebAssembly support in Rust
RUN curl https://rustwasm.github.io/wasm-pack/installer/init.sh -sSf | sh 

RUN npm install -g typescript

# Install Bevy dependencies
RUN apt-get update && \
    apt-get install -y libasound2-dev libudev-dev

