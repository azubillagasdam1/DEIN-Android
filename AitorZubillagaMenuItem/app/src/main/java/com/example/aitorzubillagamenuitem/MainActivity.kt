package com.example.aitorzubillagamenuitem

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.Menu
import android.view.MenuInflater
import android.view.MenuItem
import android.widget.Toast

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
    }

    override fun onCreateOptionsMenu(menu: Menu?): Boolean {
        super.onCreateOptionsMenu(menu)
        menuInflater.inflate(R.menu.item_menu, menu)
        return true
    }
    override fun onOptionsItemSelected(item: MenuItem): Boolean {
        when (item.itemId) {
            R.id.item1 -> {
                Toast.makeText(this, "Item 1 seleccionado", Toast.LENGTH_SHORT).show()
                return true
            }
            R.id.item2 -> {
                Toast.makeText(this, "Item 2 seleccionado", Toast.LENGTH_SHORT).show()
                return true
            }
            R.id.item3 -> {
                Toast.makeText(this, "Item 3 seleccionado", Toast.LENGTH_SHORT).show()
                return true
            }

            R.id.subitem1 -> {
                Toast.makeText(this, "subItem1 1 seleccionado", Toast.LENGTH_SHORT).show()
                return true
            }
            R.id.subitem2 -> {
                Toast.makeText(this, "subItem1 2 seleccionado", Toast.LENGTH_SHORT).show()
                return true
            }
        }
        return super.onOptionsItemSelected(item)
    }

}