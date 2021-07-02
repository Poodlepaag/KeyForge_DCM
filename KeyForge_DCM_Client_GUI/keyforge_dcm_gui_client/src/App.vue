<template>
  <div id="app">
    <Header />
    <router-view />
  </div>
</template>

<script>
  import Header from '../src/components/Header.vue';
  export default {
    name: "Home",
    created() {
      this.$store.dispatch('fetchDecks')
      this.$store.dispatch('fetchCards')
    },
    components: {
      Header,
    }
  }
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
  margin-left: 0px;
}

body {
  margin: 0;
}
</style>
