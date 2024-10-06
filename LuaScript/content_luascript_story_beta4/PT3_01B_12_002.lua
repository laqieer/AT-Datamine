-- このluaスクリプトは、PT3_01B_12_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:兄さん、おはよう！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01B_12_002002")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:おはよう、ディナタン<br>今、療養院は大変みたいだけど大丈夫か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_12_002003")


	--★★ディナタン★★:みんなのスノードン山での頑張りに比べたら<br>全然大したことないよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01B_12_002004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:それはそうと、ガラハッドさん<br>私のノート受け取ってくれてた？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01B_12_002005")


	--★★ディナタン★★:マァルに頼んでおいたんだけど…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01B_12_002006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、受け取ってたよ<br>それにすごく感謝してた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_12_002007")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ディナタン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:そっか！良かった！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01B_12_002008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ディナタン★★:なんかね…ときどきガラハッドさんが<br>少し年の離れた妹みたいに思えるときがあるの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01B_12_002009")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:少し年の離れた妹…？<br>ふたりはほとんど年齢変わらないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_12_002010")


	--★★ディナタン★★:そうなんだけど！勉強を教えてほしいって<br>頼ってきてくれるときとか
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01B_12_002011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:すごく可愛くて、なんでも言うこと<br>聞いてあげたくなっちゃうっていうか…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01B_12_002012")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:甲冑を着て騎士として振舞ってるときとは<br>かなり違うよな、確かに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_12_002013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力

	--★★ディナタン★★:そのギャップがまた可愛いんだよね！<br>本人は嫌がると思うけど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01B_12_002014")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ははっ！<br>「ガラハッドは騎士だ！」って否定するだろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_12_002015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:ね、兄さん…<br>ガラハッドさんのこと見てあげてね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01B_12_002016")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:学園でひとりでいること多いし…<br>思いつめたような表情をしてることもあるから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01B_12_002017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、わかってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_12_002018")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115200)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
