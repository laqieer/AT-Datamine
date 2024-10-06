-- このluaスクリプトは、CO_101012_0403.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101009","002","101009002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:はい、ディナタン<br>このソフトクリーム、すごくおいしいんだ
	Talk(Actor003,"NPCNAME_0239","speech","N","CO_101012_04030002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:ありがとう<br>…わ、ほんとだ。すごくおいしい！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04030003")

	change_face(Actor004,"Sad")

	--★★ノワール2★★:（なんか、普通にデートって感じだけど<br>俺、見てる必要あるのか？）
	Talk(Actor004,"CHRNAME_NOIR","mind","L","CO_101012_04030005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ノワール2★★:（…ディナタンのやつ、結構楽しそうじゃないか<br>最初はあんなに緊張してたくせに）
	Talk(Actor004,"CHRNAME_NOIR","mind","L","CO_101012_04030006")

	PlayAction(Actor003,"to  Std_Talk")

	--★★キャメロット騎士学術院（男）③★★:ディナタン、今度はこっち！<br>おすすめのスポットがあるんだ
	Talk(Actor003,"NPCNAME_0239","speech","N","CO_101012_04030007")

-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子1", "喜び")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:今日は付き合ってくれてありがとう<br>すごく楽しかったよ
	Talk(Actor003,"NPCNAME_0239","speech","N","CO_101012_04030009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定2")
-- ▲直接出力

	--★★ディナタン★★:私も楽しかった<br>色々な場所に連れてってくれてありがとう
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04030010")

	PlayAction(Actor002,"to Greet_one")
	change_face(Actor002,"Normal")

	--★★ディナタン★★:それじゃ、また学校でね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04030011")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★キャメロット騎士学術院（男）③★★:う、うん…
	Talk(Actor003,"NPCNAME_0239","speech","N","CO_101012_04030012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:…？ウィルくん、どうしたの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04030014")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:あ、あのさ…！ディナタン！！
	Talk(Actor003,"NPCNAME_0239","speech","N","CO_101012_04030016")


	--★★キャメロット騎士学術院（男）③★★:俺…君に言いたいことがあるんだ！！
	Talk(Actor003,"NPCNAME_0239","speech","N","CO_101012_04030018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力

	--★★ディナタン★★:言いたいこと…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04030019")

	PlayAction(Actor004,"to  Std_Surp")
	change_face(Actor004,"Surprise")

	--★★ノワール2★★:（ま、まさか…もう一度告白するつもりか！？）
	Talk(Actor004,"CHRNAME_NOIR","mind","L","CO_101012_04030020")


	--★★キャメロット騎士学術院（男）③★★:どうしてもこの想いを我慢できなくて…<br>君に伝えたくて…
	Talk(Actor003,"NPCNAME_0239","speech","N","CO_101012_04030021")

-- ▼直接出力
PlayPartVoice("男子1", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:俺…俺…
	Talk(Actor003,"NPCNAME_0239","speech","N","CO_101012_04030022")


	--★★ノワール2★★:（ディ、ディナタン…ッ！？）
	Talk(Actor004,"CHRNAME_NOIR","mind","L","CO_101012_04030023")

	PlayAction(Actor003,"to  Std_Talk")

	--★★キャメロット騎士学術院（男）③★★:俺…君の歌が聞きたいんだ！！
	Talk(Actor003,"NPCNAME_0239","speech","N","CO_101012_04030025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力

	--★★ディナタン★★:私の、歌…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04030026")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "肯定2")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:五月女王になったあとのインタビューで<br>歌うのが趣味だって言ってただろ？
	Talk(Actor003,"NPCNAME_0239","speech","N","CO_101012_04030027")


	--★★キャメロット騎士学術院（男）③★★:それを知って…一度でいいから<br>ディナタンの歌を聞いてみたいって思って
	Talk(Actor003,"NPCNAME_0239","speech","N","CO_101012_04030029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:そういえば、そんなこと言ったかも…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04030030")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("男子1", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:人前では恥ずかしくて歌わないって話だけど<br>でもいつか聞いてみたいんだ
	Talk(Actor003,"NPCNAME_0239","speech","N","CO_101012_04030031")

	PlayAction(Actor003,"to  Std_Talk")

	--★★キャメロット騎士学術院（男）③★★:手紙だと上手く伝えられない気がしたから<br>だから、会って話したかったんだ
	Talk(Actor003,"NPCNAME_0239","speech","N","CO_101012_04030032")


	--★★ディナタン★★:歌…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04030033")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★キャメロット騎士学術院（男）③★★:あ…もちろん無理強いする気はないから！
	Talk(Actor003,"NPCNAME_0239","speech","N","CO_101012_04030035")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:今日は付き合ってくれてありがとう<br>それじゃ…また、学校で！
	Talk(Actor003,"NPCNAME_0239","speech","N","CO_101012_04030036")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
Appear(Actor001)
keep_ik_lookat(Actor002,Actor001,"J_Head")
--フェードイン
setup_small_camera_start()
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:いい奴だったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_04030038")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:…うん<br>すごくいい人だった
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04030039")

-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力

	--★★ディナタン★★:歌、か…人前で歌うのは<br>やっぱり、今はまだ恥ずかしいけど…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04030040")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:でもいつか機会があれば…<br>歌ってみてもいいかも
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04030042")

-- ▼直接出力
local trustParam = set_communication_rankup("ディナタン_コミュランク", "ディナタン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
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
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101009","002","101009002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
