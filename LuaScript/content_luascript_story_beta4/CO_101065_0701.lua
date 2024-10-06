-- このluaスクリプトは、CO_101065_0701.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Kiss","101065001","101065001","content_animationpack_101_101kiss","MotionPack_101Kiss","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	--★★キッス★★:せっかく来てくれたのにごめんなさい<br>今から少し商談があるのよ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101065_07010004","CO_101065_07010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:待ってるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_07010007")

	change_face(Actor002,"Smile")

	--★★キッス★★:あらイイ男♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07010008")

	change_face(Actor002,"Normal")

	--★★キッス★★:10分程度で終わると思うから<br>それくらいにまた来てくれると嬉しいわ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07010009")

	reserve_next_script("1章/コミュ/x0401_キッス_ランクアップ7_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:忙しいならまた今後にするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_07010011")

	change_face(Actor002,"Normal")

	--★★キッス★★:悪いわね～。次来たときは<br>特別サービスしてあげるから♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_07010012")

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
	InitializeActiveCharacter_Preload("Kiss","101065001","101065001","content_animationpack_101_101kiss","MotionPack_101Kiss","Com_Std01_Loop_f")
end
