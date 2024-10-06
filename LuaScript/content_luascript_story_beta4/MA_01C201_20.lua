-- このluaスクリプトは、MA_01C201_20.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_02","110122_02_h")
Include("content_adv_advsmall_110122_02","Template110122_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_002)
	InitializeTemplateRandomCamera110122_02()
	InitializeTemplate110122_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ガレス", "肯定")
-- ▲直接出力

	--★★ガレス★★:だいぶ食べられるようになってきたんだな<br>ギネヴィア
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C201_200002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定")
-- ▲直接出力

	--★★ディナタン★★:はい。ガレスさんのご飯のおかげですね<br>そろそろ身体も動かせそうかなって
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_200003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ディナタン★★:ただ、やっぱりなんだか元気がないみたいです
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_200004")

	change_face(Actor001,"Normal")

	--★★ディナタン★★:私と話しているときは前みたいに<br>笑ってくれたりするんですけど、でも…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_200005")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:でもふとしたときに、なんだか<br>すごく寂しい顔をしていて
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_200006")

	change_face(Actor002,"Sad")

	--★★ガレス★★:そっか
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C201_200007")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガレス", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:なら、そろそろわたしもお見舞いに行こうかな<br>聞きたいこともあるし
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C201_200008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガレス★★:ランスロットと一緒にいたんだ<br>ギネヴィアもなにか知ってるかもしれない
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C201_200009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガレス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:兄さんのこと…<br>ほら、ちゃんとご飯食べてるのかとかさ♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C201_200010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:ガレスさん…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_200012")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:…ほんとは、もっと早くに行けばよかった<br>けど、知るのが怖くて
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C201_200014")

	change_face(Actor002,"Normal")

	--★★ガレス★★:でもいい加減、向き合わなきゃな
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C201_200015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:次、ご飯持ってくときは<br>わたしもついてくよ?
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C201_200016")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
