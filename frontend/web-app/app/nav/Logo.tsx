'use client'

import { useParamsStore } from '@/hooks/useParamsStore'
import React from 'react'
import { IoCarSportSharp } from "react-icons/io5";

export default function Logo() {
    const reset = useParamsStore(state => state.reset);

    return (
        <div onClick={reset} className='cursor-pointer flex items-center gap-2 text-3xl font-semibold text-green-800'>
            <IoCarSportSharp  size={34}/>
            <div>CarBit Auctions</div>
        </div>
    )
}