-- このluaスクリプトは、CO_101013_0501.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
	Actor003 = InitializeActiveCharacter("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	--★★ガウェイン★★:キンイロチョウが入った琥珀を買うために<br>カネを稼ごうと思ってんだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101013_05010004","CO_101013_05010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺も手伝うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_05010007")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:悪いな<br>付き合ってもらっちゃってよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:トムのためだしな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_05010009")

	change_face(Actor002,"Sad")

	--★★ガウェイン★★:それにしても円卓の騎士が金稼ぎとはねえ<br>世知辛いもんだぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05010011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺の知り合いも言ってたよ<br>「日々は地獄。その沙汰だったら金次第」って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_05010012")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:俺もたぶん聞いたことあるわ、それ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05010014")

	change_face(Actor002,"Sad")

	--★★ガウェイン★★:しかしよ。手っ取り早くカネを稼ぐには<br>どうしたらいいもんかな？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05010015")

	change_face(Actor001,"Normal")

	--★★ノワール★★:うーん<br>キッスさんに働き口を紹介してもらうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_05010016")

	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:キッスさんって、情報屋の？<br>いいかもしんねーな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05010017")

	change_face(Actor002,"Smile")

	--★★ガウェイン★★:早速酒場に行ってみよーぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05010018")

	change_face(Actor003,"Surprise")

	--★★ラグネル★★:待って待って！<br>あたしも行くよーっ！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_05010020")

	change_face(Actor002,"Smile")

	--★★ガウェイン★★:置いてくつもりはねーから<br>心配すんなって
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05010021")

	reserve_next_script("1章/コミュ/x0401_ガウェイン_ランクアップ5_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:これから用事があってさ<br>今はムリなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_05010023")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:そっか<br>あとでヒマなときさ、相談乗ってくれよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05010024")

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
	InitializeActiveCharacter_Preload("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
end
