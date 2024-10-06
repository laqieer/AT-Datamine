-- このluaスクリプトは、AV_01_101022.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera002 = SetTemplate("Actor002",30,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_sequence_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★モルドレッド★★:オイ！てめえ、こんなとこで<br>なにボーっと突っ立ってやがる
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","AV_01_101022_0001")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:モルドレッドか<br>別にただ突っ立ってるわけじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101022_0002")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:警備の手伝いで<br>市街の見回りをしてるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101022_0003")

-- ▼直接出力
PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:警備だぁ？<br>この街は平和ボケした連中ばっかりだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","AV_01_101022_0004")


	--★★モルドレッド★★:街のなかで<br>大した事件なんか起きねぇだろ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","AV_01_101022_0005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:起きるさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101022_0006")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("モルドレッド", "納得")
-- ▲直接出力

	--★★モルドレッド★★:へえ？<br>どんな事件が起きんのか聞かせてくれよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","AV_01_101022_0007")

	open_select_window_tag(Actor001,"Normal","AV_01_101022_0008","AV_01_101022_0009","AV_01_101022_0010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:モルドレッドも<br>学園がバルバロイに襲われたのを見たろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101022_0012")

	change_face(Actor001,"Normal")

	--★★ノワール★★:今は<br>どこにバルバロイが潜んでいてもおかしくない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101022_0013")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:学園の生徒はともかくとして<br>市民は戦う力をもたない者ばかりだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101022_0014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺たちが守ってやらないと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101022_0015")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★モルドレッド★★:チッ…好きじゃねぇんだよ<br>長々と正論を垂れるヤツは
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","AV_01_101022_0016")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:わかったわかった<br>継承者サマの邪魔はしねぇよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","AV_01_101022_0017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:手伝いもしねぇけどな<br>ま、せいぜい頑張りな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","AV_01_101022_0018")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:たとえば…<br>街の人たちのケンカとか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101022_0020")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:そらみろ！<br>やっぱり大した事件なんか起きねぇ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","AV_01_101022_0021")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:大したことはなくはないぞ？<br>放っておいたら、殴り合いに発展することもある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101022_0022")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("モルドレッド", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:おお、それは大変だ！<br>腕や足の骨が折れてしまうかもしれない！
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","AV_01_101022_0023")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Anger")

	--★★ノワール★★:お前なあ…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101022_0024")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:いいことじゃねぇか<br>街が平和だってのはよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","AV_01_101022_0025")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:しっかり守ってやんな、継承者サマ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","AV_01_101022_0026")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:大したことは…<br>たしかにこれまでに起きてないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101022_0028")

-- ▼直接出力
PlayPartVoice("モルドレッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:は…？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","AV_01_101022_0029")

	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:なんだよなんだよ<br>張り合いのねぇヤロウだな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","AV_01_101022_0030")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:お似合いだよ<br>ここでボーッと平和な街並でも眺めてな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","AV_01_101022_0031")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:オレはもう行くぜ<br>学園になら、ほかの遊び相手もいそうだしな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","AV_01_101022_0032")

	goto Block1end

::Block1end::
-- ▼直接出力
local commu = system.GetCommu() -- 実行中コミュ
local commuChara = commu.GetCharacter()
kizuna_gaugeup_encount(Actor002,commuChara.CharaName)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_sequence_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
