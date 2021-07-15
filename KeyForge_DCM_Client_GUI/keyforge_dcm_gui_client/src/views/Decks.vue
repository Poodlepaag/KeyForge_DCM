<template>
    <div class="searchbar-wrapper">
        <Searchbar />
    </div>
    <div>
        <div v-if="search == undefined">
            <ul class="list-of-results">
                <li v-for="deck in decks" :key="deck.deckId">
                    <h3>{{ deck.deckId }}, {{ deck.deckName }}</h3>
                    <hr class="difference-line">
                </li>
            </ul>
        </div>
        <div v-else>
            <ul class="list-of-results" v-for="deck in decks" :key="deck.deckId">
                <li v-if="deck.deckName.toLowerCase().includes(search)">
                    <h3>{{ deck.deckId }}, {{ deck.deckName }}</h3>
                    <hr class="difference-line">
                </li>
            </ul>
        </div>
    </div>
</template>

<script>
    import Searchbar from '../components/Searchbar.vue'
    export default {
        data() {
            return {
                decks: [],
            }            
        },
        components: {
            Searchbar,
        },
        computed: {
            search(){
                return this.$store.state.searches
            },
        },
        mounted() {
            this.decks = this.$store.state.decks
        }
    };
</script>

<style>
.list-of-results {
  list-style: none;
  width: 90%;
  margin: auto;
}

.searchbar-wrapper {
    text-align: center;
    margin: 40px auto;
}

.difference-line {
    opacity: 20%;
}
</style>
