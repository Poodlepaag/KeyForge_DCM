<template>
  <div>
    <Searchbar />
  </div>
  <div>
    <h1>KeyForge Deck Collection Manager</h1>
    <p>Decks</p>
      <div v-if="searchString == ''">
        <ul class="list-of-results">
          <li v-for="deck in decks" :key="deck">
            <h3>{{deck.deckId}}, {{deck.deckName}}</h3>
          </li>
        </ul>
      </div>
      <div v-else>
        <ul class="list-of-results" v-for="deck in decks" :key="deck">
          <li v-if="deck.deckName.toLowerCase().includes(searchString)">
            <h3>{{deck.deckId}}, {{deck.deckName}}</h3>
          </li>
        </ul>  
      </div>
  </div>
</template>

<script>
import Searchbar from '../components/Searchbar.vue'

export default {
  components: { 
    Searchbar,
    },

  computed: {
    decks(){
      return this.$store.state.decks
    },
    searchString(){
      return this.$store.state.searches
    },
  }
}
</script>

<style scoped>
.list-of-results {
  list-style: none;
}
</style>
