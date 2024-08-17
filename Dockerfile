FROM node:18-alpine as builder
WORKDIR /app
COPY client/package.json client/package-lock.json ./
RUN npm install
COPY client /app
RUN npm run build

FROM node:18-alpine
WORKDIR /app
COPY --from=builder /app/build /app/build
RUN npm install -g serve
CMD serve -s -l 8080 build

