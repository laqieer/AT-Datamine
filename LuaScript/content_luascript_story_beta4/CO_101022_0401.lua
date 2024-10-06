-- このluaスクリプトは、CO_101022_0401.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Mordred","101022001","101022001","content_animationpack_101_101mord","MotionPack_101Mord","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	--★★モルドレッド★★:ちょっとツラ貸せ。継承者
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101022_04010004","CO_101022_04010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:いいけど…また任務か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04010007")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:いや、今日は別件だ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04010008")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:療養院で薬を貰って来い/今すぐだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04010009")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？怪我でもしたのか？/なら直接療養院で診てもらったほうが…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04010010")

	change_face(Actor002,"Anger")

	--★★モルドレッド★★:オレじゃねえ！/クラリスがポカやって怪我したんだ！
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04010011")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:そうなのか！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04010012")

	change_face(Actor001,"Sad")

	--★★ノワール★★:いやでも、だからってなんで俺が…？/あんたが行くところじゃないのかそれは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04010014")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:嫌いなんだよ。あそこは
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04010015")

	change_face(Actor001,"Normal")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04010016")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:療養院。あの女の居城だったからな/今はいねえが、大して変わらねぇ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04010017")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:だからって俺に行かせるのは/横暴すぎやしないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04010019")

	change_face(Actor002,"Anger")

	--★★モルドレッド★★:あ！？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04010020")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ほら、行くぞ/着いてってやるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04010021")

	change_face(Actor002,"Anger")

	--★★モルドレッド★★:おい、てめえ今オレのこと/ガキ扱いしたか！？いい度胸だ！！
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04010022")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（うるさいなぁ…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101022_04010023")

	reserve_next_script("1章/コミュ/x0401_モルドレッド_ランクアップ4_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪い、今は無理だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04010025")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:ほう？/じゃあ今すぐ無理じゃなくしてこい
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04010026")

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
	InitializeActiveCharacter_Preload("Mordred","101022001","101022001","content_animationpack_101_101mord","MotionPack_101Mord","Com_Std01_Loop_m")
end
