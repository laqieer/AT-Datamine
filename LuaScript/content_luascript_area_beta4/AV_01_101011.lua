-- このluaスクリプトは、AV_01_101011.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_03","112021_03_h")
Include("content_adv_advsmall_112021_03","Template112021_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_002)
	InitializeTemplateRandomCamera112021_03()
	InitializeTemplate112021_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_sequence_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
voice_play("VO_101011_sp_0001_1")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:あら、ノワールじゃない<br>こんなところでなにしてるの？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AV_01_101011_0001")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:やあ、ギネヴィア<br>ちょっとマルイルの店の手伝いをな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101011_0002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:よく学び、よく訓練し、よく働く<br>キャメ学生徒の鑑ね。感心、感心
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AV_01_101011_0003")

	change_face(Actor001,"Normal")

	--★★ノワール★★:なんだそれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101011_0004")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:そうだ！ねえ、店員さんわたしの好みに合いそうな物、選んでくださる？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AV_01_101011_0005")


	--★★ノワール★★:手伝いはもう終わったんだけど…まぁ、少しならいいか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101011_0006")

	open_select_window_tag(Actor001,"Normal","AV_01_101011_0007","AV_01_101011_0008","AV_01_101011_0009")
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
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そうだなあ<br>この宝石なんかどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101011_0011")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:あら、綺麗！素敵じゃない！<br>わたしにピッタリ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AV_01_101011_0012")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:でも、これ、かなり高いぞ？<br>キミの小遣いで買うには…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101011_0013")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:買うつもりはないわよ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AV_01_101011_0014")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101011_0015")

	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:わたしは「選んでくださる？」と言ったの<br>「買っていく」なんて言ってないわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AV_01_101011_0016")

	PlayAction(Actor002,"to Finger")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:アナタの見る目を確かめたかっただけだもの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AV_01_101011_0017")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:…冷やかしなら帰ってくれ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101011_0018")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺は仕入れから手伝っているわけじゃないし<br>どれがいい物なのかって言われても…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101011_0020")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:あ、これ<br>カレドニアにいた頃、よく見たな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101011_0021")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:スカーフ？<br>タータン柄って言うんだっけ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AV_01_101011_0022")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ああ。カレドニアのおしゃれの基本だな<br>母さんもこの柄のスカートをよく穿いてた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101011_0023")

	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:………
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AV_01_101011_0024")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:な、なんだよ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101011_0025")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:続けて<br>昔から好きなの。異国の地の話を聞くの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AV_01_101011_0026")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いいけど…<br>話を続けたら、買ってくれるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101011_0027")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:わたしを満足させてくれたら<br>考えてもいいかな
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AV_01_101011_0028")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:えーっと、ごめん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101011_0030")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:は？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AV_01_101011_0031")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:仕入れから手伝っているわけじゃないから<br>俺には品物の良し悪しはわからない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101011_0032")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0033")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:あっきれた<br>商人どころか、売り子も失格よ、そんなんじゃ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AV_01_101011_0033")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:まぁ、正直に説明するのは悪いことじゃないし<br>そもそもアナタは商人でもないけど
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AV_01_101011_0034")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:次までには<br>もう少し勉強しとくよ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101011_0035")

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
	load_sequence_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
