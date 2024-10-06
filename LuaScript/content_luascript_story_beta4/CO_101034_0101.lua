-- このluaスクリプトは、CO_101034_0101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_05","110071_05_h")
Include("content_adv_advsmall_110071_05","Template110071_05_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_05_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_05_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_05_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_05_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_003)
	InitializeTemplateRandomCamera110071_05()
	InitializeTemplate110071_05()
-- ▼直接出力
DontChangeRandomCamera(true)
set_enable_auto_lookat_all(false)
turn_lookat(Actor001,Actor003,0)
turn_lookat(Actor002,Actor001,0)
turn_lookat(Actor003,Actor001,0)
turn_lookat(Actor004,Actor001,0.1)
Hide(Actor002)
Hide(Actor003)
Hide(Actor004)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad01")
wait_time(2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
Appear(Actor003)
Appear(Actor004)
Appear(Actor002)
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:今日は任務の予定もないし久々にゆっくりできそうだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_01010002")

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
setup_small_camera_end()
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:やっほー！ノワール！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101034_01010004")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:やあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_01010005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Sad01")
-- ▼直接出力
change_face(Actor001,"Normal")
PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力

	--★★リリアーナ★★:こ、こんにちは…
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","CO_101034_01010006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:こんにちは、ノワール
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01010007")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:３人はここでなにをしてるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_01010008")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力

	--★★フィエナ★★:ひなたぼっこだよ！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101034_01010009")

	PlayAction(Actor004,"to  Std_Talk")

	--★★リリアーナ★★:今日は任務がないみたいですしたまにはリフレッシュをしようかなって
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","CO_101034_01010010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エクセリア★★:ただ外にいるだけでリフレッシュができるのか試しているのよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01010011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ん？どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_01010012")

-- ▼直接出力
PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★リリアーナ★★:えっと…その…エクセリアにリフレッシュを提案したんです
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","CO_101034_01010013")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★フィエナ★★:そしたらエクセリアってば
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101034_01010014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")

	--★★フィエナ★★:「リフレッシュってどうやればいいのかしら」…なーんて真面目な顔して言うんだもん！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101034_01010015")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("エクセリア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:リフレッシュってなにをすればいいのか…これまで戦い詰めだったからよくわからないのよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01010017")


	--★★エクセリア★★:アダンも教えてくれなかったし
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01010018")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:そこでこのふたりにお手本を見せてもらおうと思って
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01010019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101034_01010021","CO_101034_01010022","CO_101034_01010023")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:リフレッシュってお手本が必要なことか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_01010025")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:えぇ、私には経験のないことだからまずは情報を集めないと
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01010026")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（そんなに真面目に考えてたらちっともリフレッシュにならないんじゃないか）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101034_01010027")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:たしかにひなたぼっこはにいいかも俺もリフレッシュしたいときに、たまにやるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_01010029")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:室内で座っているときとなにも変わらない気がするのだけれど
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01010030")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:もしかして個人差があるのかしら
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01010031")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、まあ、なんというか…あるかも、しれないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_01010032")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:リフレッシュだったら俺は散歩をオススメしたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_01010034")

-- ▼直接出力
PlayPartVoice("エクセリア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:散歩？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01010035")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ひなたぼっこもいいんだけど俺はじっとしてるよりも動いていたいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_01010036")

-- ▼直接出力
PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★フィエナ★★:せっかくのオフなのに？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101034_01010037")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:せっかくのオフだからかもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_01010038")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:その気持ち、なんだかわかるわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01010039")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★エクセリア★★:私もこうして座っているけどなんだか落ち着かなくて…
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01010040")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to Finger")
-- ▼直接出力
PlayPartVoice("フィエナ", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:ちなみにひなたぼっこは私がオススメしたんだよ！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101034_01010042")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★リリアーナ★★:おかげで私はすごくリフレッシュできてます
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","CO_101034_01010043")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:リリアーナのオススメのリフレッシュ方法はないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_01010044")

	PlayAction(Actor004,"to  Std_No")
-- ▼直接出力
set_enable_auto_lookat_all(true)
PlayPartVoice("リリアーナ", "落胆")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★リリアーナ★★:私のなんて聞いても面白くないですよ…？
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","CO_101034_01010045")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:そんなことないわよ参考にしたいから教えて欲しいわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01010046")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力

	--★★フィエナ★★:フィエナちゃんも聞きたーい！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101034_01010047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力

	--★★リリアーナ★★:え、えっと、えっと…草笛を吹くこと、です…
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","CO_101034_01010048")

-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力

	--★★フィエナ★★:リリアーナってば草笛がすっごく上手なんだよ！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101034_01010050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力

	--★★エクセリア★★:草笛に使う葉っぱはなんでもいいの？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01010051")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("リリアーナ", "悩む")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★リリアーナ★★:口が隠れるくらいの大きさは必要かな…？
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","CO_101034_01010052")


	--★★リリアーナ★★:あとは土いじりなんかもオススメです
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","CO_101034_01010053")

-- ▼直接出力
PlayPartVoice("エクセリア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エクセリア★★:土をいじることのなにが楽しいの？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01010054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("リリアーナ", "苦しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★リリアーナ★★:ううっ…わかりやすくいうと畑仕事です作物の成長を毎日見守ってあげるんです
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","CO_101034_01010055")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★エクセリア★★:ああ…。コルベニック城にいた頃やっていたわね、あなた
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01010056")


	--★★エクセリア★★:あらためて土をいじる方法を教えてもらえるかしら
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01010057")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:うーん。なにでリフレッシュできるかは人によってまちまちだと思うな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_01010059")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:そうみたいね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01010060")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:だからエクセリアも自分なりのリフレッシュ方法をだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_01010061")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エクセリア★★:もう少しデータが欲しいわね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01010063")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:デ、データ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_01010064")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定")
-- ▲直接出力

	--★★エクセリア★★:他の人にも聞いてみなくては
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01010065")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera002)
end
-- ▲直接出力
	PlayAction(Actor002,"to Bow")

	--★★エクセリア★★:私はここで失礼するわ色々教えてくれてありがとう
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_01010067")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
set_rot(Actor001,{0,-30,0})
set_rot(Actor003,{0,0,0})
set_rot(Actor004,{0,0,0})
set_pos(Actor002,{-2.06, 0.128, 29.35})
turn_chara(Actor002,0,0)
set_enable_auto_lookat_all(false)
setup_small_camera_start(RndCamera009)
change_face(Actor003,"Normal")
change_face(Actor004,"Normal")
wait_time(TIME_ELAPSED)
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,{-2.06, 0.128, 33.35},3.2)
fadein(FADE_TIME)
wait_time(3.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera005)
Hide(Actor002)
set_enable_auto_lookat_all(false)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat(Actor003,Actor001,0.8)
lookat_delay_weight_reset(Actor003,0.6)
wait_time(0.5)
PlayActionDirect(Actor004,"to Wlk")
turn_lookat(Actor004,Actor001,0.8)
lookat_delay_weight_reset(Actor004,0.6)
wait_time(0.3)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.5)
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★フィエナ★★:ねぇ、ノワール
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101034_01010069")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_01010070")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★フィエナ★★:晩ごはんまでには帰るようにってあの子に言ってきてくれる？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101034_01010071")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？俺が？<br>…まぁ、いいか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_01010072")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_エクセリア_ランクアップ1_2")
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
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
