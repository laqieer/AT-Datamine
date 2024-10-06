-- このluaスクリプトは、CO_101001_0303.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",200,CharaPos110011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力

	--★★ガウェイン★★:え～っと、なになに…
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101001_03030002")

	change_face(Actor003,"Sad")

	--★★ガウェイン★★:「ローマがブリテン島に最初に築いた街の名前を<br>当時の呼びかたで答えよ」か…
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101001_03030003")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ラグネル", "悩む")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ラグネル★★:街の名前か～。なんだっけ…？<br>カム…カムロ…
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","CO_101001_03030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Pain")

	--★★ラグネル★★:あぁ～出て来ない！
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","CO_101001_03030006")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:ノートのこの辺に書いたと思うんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_03030007")


	--★★ティルフィング★★:カムロドゥノン
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_03030008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ティルフィング★★:この地に生きた太古の民の言葉で<br>「カムロスの要塞」という意味です
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_03030009")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:それだ～！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101001_03030011")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラグネル", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ラグネル★★:っていうか、ティルちゃん<br>まさかこれ暗記してるの！？すごっ！
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","CO_101001_03030012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ティルフィング", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:ティ、ティルちゃん…？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_03030014")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ティルフィング★★:い、いえ、偶然記憶していただけです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_03030016")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ガウェイン★★:いやいや、十分スゲーよ！<br>さっきから、いいトコで助け船出してくれるし！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101001_03030017")

	open_select_window_tag(Actor001,"Normal","CO_101001_03030019","CO_101001_03030020")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:お、俺だってわかってたし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_03030022")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:嘘つけ！<br>同じように悩んでただろ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101001_03030023")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ノートに書いたことは覚えてた<br>あとちょっとでたどり着くとこだったんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_03030024")

	change_face(Actor004,"Normal")

	--★★ラグネル★★:こういうところでムキになるのって<br>あんまりカッコよくないよ、ノワール
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","CO_101001_03030025")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:すごいだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_03030027")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:ティルフィングは<br>ブリテンで起きたことをほとんど知ってるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_03030028")

	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:お前がドヤ顔してる理由はわかんねーけど<br>マジスゲーな、ティルフィング！！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101001_03030029")

	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:マ、マスター！あまり話を盛らないでください…<br>あくまで、大まかに知っているだけですから
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_03030031")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:いやいや<br>大まかでも十分すごいし、頼もしいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_03030032")

-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:…ありがとうございます
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_03030034")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ティルフィングは名称と一緒に<br>その歴史も教えてくれるからタメになるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_03030036")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:分かる！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101001_03030037")


	--★★ガウェイン★★:さっきの、ナントカの要塞ってやつ<br>超カッコよくてテンションあがるぜ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101001_03030038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ラグネル★★:太古の民の言葉かぁ～<br>なんだか歴史を感じるよね～
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","CO_101001_03030039")

	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:歴史を…感じる…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_03030040")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:実際、今やってるのは史学なんだけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_03030042")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Surprise")

	--★★ラグネル★★:わ、わかってるよ！
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","CO_101001_03030044")

	PlayAction(Actor003,"to  Std_Joy")

	--★★ガウェイン★★:よーし、テンション上がってきたついでに<br>さっさと残りも片付けちまおうぜ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101001_03030045")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ティルフィング_ランクアップ3_4")
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
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
