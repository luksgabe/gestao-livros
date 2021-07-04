FROM node:1.13.3-alpine AS base
EXPOSE 80

FROM node:14.11.0-stretch AS build
WORKDIR /app
COPY . .

ARG NODE_ENV
RUN echo ${NODE_ENV}
COPY ./env/${NODE_ENV}.env .env

COPY package.json /app/package.json
RUN yarn
RUN yarn run build

FROM build AS publish
RUN mv /app/build/ /build

FROM base AS final
RUN apk add --no-cache tzdata
ENV TZ=America/Sao_Paulo
RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone

CMD ["yarn", "start"]