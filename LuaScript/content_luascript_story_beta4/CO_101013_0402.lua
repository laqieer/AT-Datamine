-- このluaスクリプトは、CO_101013_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_02","110061_02_h")
Include("content_adv_advsmall_110061_02","Template110061_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_002)
	InitializeTemplateRandomCamera110061_02()
	InitializeTemplate110061_02()
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
lookat_weight(Actor001,0.4, 0.08, 0.7, 0.6)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
   prop_001    = load_particle("content_prop_10103001", "10103001_PropModel", false, false)
    set_pos(prop_001,{4.0527,0.814,10.581})
    set_rot(prop_001,{0,-89.8,0})
   prop_002    = load_particle("content_prop_10103002", "10103002_PropModel", false, false)
    set_pos(prop_002,{4.0604,0.8525,10.581})
    set_rot(prop_002,{0,-110.8,0})
   prop_003    = load_particle("content_prop_10103003", "10103003_PropModel", false, false)
    set_pos(prop_003,{4.063,0.8904,10.581})
    set_rot(prop_003,{0,-89.8,0})
   prop_004    = load_particle("content_prop_10103004", "10103004_PropModel", false, false)
    set_pos(prop_004,{3.729,0.813,10.611})
    set_rot(prop_004,{0,-207.7,0})
prop_005    = load_particle("content_prop_10106005", "10106005_PropModel", false, false)
    set_pos(prop_005,{3.936,0.813,10.351})
    set_rot(prop_005,{0,-1.6,0})
prop_006    = load_particle("content_prop_10106005", "10106005_PropModel", false, false)
    set_pos(prop_006,{3.183,0.813,10.351})
    set_rot(prop_006,{0,-1.6,0})
-- ▲直接出力
-- ▼直接出力
on_active(prop_001)
on_active(prop_002)
on_active(prop_003)
on_active(prop_004)
on_active(prop_005)
on_active(prop_006)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力

	--★★ガウェイン★★:えーっと…蝶、蝶…っと…<br>蝶の項目はどこだ…？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020002")

	change_face(Actor002,"Sad")

	--★★ガウェイン★★:ログレスマダラアゲハ…違うな…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:ずいぶん一生懸命だな、ガウェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020005")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:あ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101013_04020008","CO_101013_04020009","CO_101013_04020010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:誰かのために頑張れるって<br>すごくかっこいいことだと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020012")

-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:な、なんだよ突然…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020013")

	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:あれか？メシでもおごってほしいのか？<br>俺、今あんまり手持ちがねーんだよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020014")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:おだてたわけじゃないよ<br>本当にそう思ったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020015")

-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:あ、そうなの？<br>ありがとな…なんか照れくせーけど
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:その頑張りを<br>勉強にも活かせばいいのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020018")

-- ▼直接出力
PlayPartVoice("ガウェイン", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガウェイン★★:うっせ！勉強の成績は<br>俺もお前もあんまり変わらないだろ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020019")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それはどうかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020020")

-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:まさかお前<br>俺に隠れて勉強してんのか！？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020021")

	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:たしかにここで本を探すのも<br>だいぶ手慣れていた気がする…！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020022")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ここだと<br>太陽が出ているか確認できないのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020024")

-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:勘違いしてるヤツも多いから<br>言っておくけどな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020025")

	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:俺は太陽が出ていたら強い<br>わけじゃないからな？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020026")

-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:ふだんから強いけど<br>太陽が出ていたらもっと強いんだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020027")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:わ、わかった<br>憶えておくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020028")

	goto Block1end

::Block1end::
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:頑張って当たり前だ<br>トムを喜ばせてやりてーからな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020030")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:うん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガウェイン★★:…っておい！なにボーッとしてんだよ<br>お前もキンイロチョウについて調べろよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020034")

	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:…あった、キンイロチョウについての情報
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020036")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:えーっと、ログレスサンシャインバタフライ…<br>通称キンイロチョウは生息数の少ない蝶である
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020038")


	--★★ノワール★★:「太陽の光を翅に蓄えるという特徴があり<br>夜であっても朝陽のごとく金色に輝いて舞う」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:「その特徴から好事家たちの人気が高いが<br>捕まえるのは困難」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020040")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:「人間の手が触れると<br>翅の色はとたんに濁ったような色に変わり」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:「場合によっては<br>そのまま息絶えてしまうこともある」…だって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020042")

-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力

	--★★ガウェイン★★:なっ、なんだこれ！？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020044")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:捕まえるさいは手で触れてしまわないよう<br>細心の注意が必要となる…だって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020045")

-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力

	--★★ガウェイン★★:手で触れちゃダメって<br>じゃあどうやって捕まえるんだよ！？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101013_04020048","CO_101013_04020049")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:網で捕まえたあと<br>カゴに入れるとか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020051")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:カゴに入れるときに<br>手で触れる必要があるだろ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020052")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そっか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020053")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:なにかうまい方法がないか<br>探してみようぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020054")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:手で触れられないとすると…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020056")

	change_face(Actor001,"Normal")

	--★★ノワール★★:うまいこと虫かごに誘導するとか<br>育てるとかか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020057")

-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:どっちにしても虫にあんまり知識のない俺らにゃ<br>難しそうだな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020058")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:だからといって蝶のこと<br>諦めるつもりはないんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020059")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:もちろん
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020060")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:それなら、他にいい方法がないか<br>とことん調べてみよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020061")

-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:そう言ってくれると助かるぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020062")

	goto Block2end

::Block2end::
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:ダメだ～<br>どの本に確実な捕まえかたは載ってねえ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020064")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん、参ったな…<br>誰か詳しい人でもいないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_04020065")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:街に出て聞いてみるか
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_04020066")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガウェイン_ランクアップ4_3")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
   load_particle_preload("content_prop_10103001", "10103001_PropModel", false, false)
   load_particle_preload("content_prop_10103002", "10103002_PropModel", false, false)
   load_particle_preload("content_prop_10103003", "10103003_PropModel", false, false)
   load_particle_preload("content_prop_10103004", "10103004_PropModel", false, false)
load_particle_preload("content_prop_10106005", "10106005_PropModel", false, false)
load_particle_preload("content_prop_10106005", "10106005_PropModel", false, false)
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
