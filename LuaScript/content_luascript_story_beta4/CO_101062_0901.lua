-- このluaスクリプトは、CO_101062_0901.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Maril","101062001","101062001","content_animationpack_101_101mari","MotionPack_101Mari","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	--★★マルイル★★:ノワールさん、今お時間ありますか？<br>…素材の仕入れに行きたいんですが
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_09010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101062_09010004","CO_101062_09010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Serious")

	--★★ノワール★★:もちろん付き合うよ<br>お爺さんのために
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_09010007")

	change_face(Actor002,"Smile")

	--★★マルイル★★:ありがとうございます…！<br>では…早速行きましょう
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_09010008")

	reserve_next_script("1章/コミュ/x0401_マルイル_ランクアップ9_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪い、今はちょっと忙しいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_09010010")

	change_face(Actor002,"Normal")

	--★★マルイル★★:わかりました<br>お時間があるときに付き合ってください
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_09010011")

	system.Cancel()

	goto Block1end

::Block1end::
	EndPlayActive()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Maril","101062001","101062001","content_animationpack_101_101mari","MotionPack_101Mari","Com_Std01_Loop_m")
end
