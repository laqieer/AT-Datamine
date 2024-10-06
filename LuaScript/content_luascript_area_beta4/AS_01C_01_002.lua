-- このluaスクリプトは、AS_C.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gareth","101032001","101032001","content_animationpack_101_101gare","MotionPack_101Gare","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ガレス★★:聞いたか、ノワール！？<br>ギネヴィアが戻ってきたらしいぞ！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AS_01C_01_0010002")


	--★★ガレス★★:こないだギネマウアが言ってたんだろ？<br>ギネヴィアはノワールに会いに来るって
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AS_01C_01_0010003")


	--★★ガレス★★:早く迎えに行ってやろう！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AS_01C_01_0010004")

	EndPlayActive()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Gareth","101032001","101032001","content_animationpack_101_101gare","MotionPack_101Gare","Com_Std01_Loop_f")
end
