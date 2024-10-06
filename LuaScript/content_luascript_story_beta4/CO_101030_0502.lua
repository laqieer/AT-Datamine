-- このluaスクリプトは、CO_101030_0502.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_02","110061_02_h")
Include("content_adv_advsmall_110061_02","Template110061_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",40,CharaPos110061_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_001)
	Camera002 = SetTemplate("Actor002",-50,CharaPos110061_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_002)
	InitializeTemplateRandomCamera110061_02()
	InitializeTemplate110061_02()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
chair = get_object("geo_chair_11")
set_rot(chair, {0,40,0}) 
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera003)
PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:トビーくんのお父さんについてお兄ちゃんが調べてくれているんですが
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020002")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★エレイン★★:まだ居場所はわからないそうです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020003")

-- ▼直接出力
setup_small_camera_end(RndCamera003)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:早く見つけてトビーや奥さんのことを知らせてやりたいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_05020004")


	--★★ノワール★★:お父さんに会えたらトビーも元気になって目も治るかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_05020005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:はいそれで、ですね…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020006")


	--★★エレイン★★:お父さんが見つかるまでに私になにかできることはないか考えたんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:うん、それで？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_05020008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:ロンディニウムにいる子供たちにトビーくんへ手紙を書いてもらうのはどうかなと
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0046")
-- ▲直接出力

	--★★ノワール★★:なるほど手紙で元気づけてやろうってわけか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_05020010")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力

	--★★ノワール★★:でもエレイン今のトビーは目がほとんど見えないんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_05020011")

-- ▼直接出力
PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:預かった手紙は私が持って行って１通１通読んであげようと思っています
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:うんエレインらしい、すごくいいアイデアだと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_05020013")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101030_sp_0001_3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:…先輩。この前、お話しましたよね私は徒花だって
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020015")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…うん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_05020016")


	--★★エレイン★★:「新しい美姫の誕生だ！」<br>そう喜んでいてくれた村のみなさんも
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020017")

-- ▼直接出力
PlayPartVoice("エレイン", "落胆")
-- ▲直接出力

	--★★エレイン★★:私がなにもできないと知ると少しずつ私から離れていきました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★エレイン★★:「エレインちゃんは女の子だからね」「エレインちゃんの頑張りはみんなが見てる」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020019")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★エレイン★★:…なんて励ましてくれる人もいましたけれどその目は真逆のことを言っているように思えて
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020020")

-- ▼直接出力
setup_small_camera_end(RndCamera003)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エレイン", "否定")
-- ▲直接出力

	--★★エレイン★★:言葉の裏に隠された本当のことを知るのが嫌で私は人の目を見るが怖くなってしまいました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020021")


	--★★エレイン★★:塞ぎ込み、部屋に閉じこもり人と会うことをやめた私を救ってくれたのは
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:お兄ちゃんからの手紙でした
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エレイン★★:「目を見るのが怖いなら、まずは手紙で話そう」手紙にはそう綴られていました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020024")

-- ▼直接出力
PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力

	--★★エレイン★★:手紙での会話なら人の目を見なくても済みますし言葉の裏に別の意味が隠されてもいません
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020025")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_05020026")


	--★★エレイン★★:お兄ちゃんのおかげで、手紙越しですが私は少しずつ人と話せるようになったんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020028")

	open_select_window_tag(Actor001,"Normal","CO_101030_05020030","CO_101030_05020031")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:手紙を通じての会話なら嘘がつけないラヴェインはそれが伝えたかったんだろうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_05020033")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺は違うと思う手紙でだって嘘はつける
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_05020034")

	change_face(Actor001,"Normal")

	--★★ノワール★★:手紙をきっかけにまた少しずつ人と触れ合っていこう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_05020035")

	change_face(Actor001,"Normal")

	--★★ノワール★★:そんなことが伝えたかったんじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_05020036")

-- ▼直接出力
PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:手紙をきっかけに…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020037")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
voice_play("VO_101009_sp_0016_1")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:エレイン、キミは間違っている
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_05020039")

	change_face(Actor001,"Normal")

	--★★ノワール★★:みんなの期待に応えられなかったその恥ずかしさから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_05020040")

	change_face(Actor001,"Normal")

	--★★ノワール★★:キミは他人の目をまっすぐ見返すことができなくなっていたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_05020041")

	change_face(Actor001,"Normal")

	--★★ノワール★★:励ましてくれた人たちの目をきちんと見たのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_05020042")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:それ、は…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020043")

-- ▼直接出力
setup_small_camera_end(RndCamera003)
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ラヴェインは手紙をきっかけにキミを正しい道に戻してくれたんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_05020044")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("エレイン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:私は間違って、いた…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020046")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:でも、トビーに手紙を送るというアイデアは俺も賛成だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_05020047")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:…はい。私とトビーくんの置かれた状況は違うものの
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020048")


	--★★エレイン★★:手紙がトビーくんの怖さを紛らわしてあげられると思うんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020049")

-- ▼直接出力
　--時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
setup_small_camera_end()
set_animationcontroller(Actor002, "Chr_520_01_StdController", "to Std_Loop")
Camera002 = setup_small_camera_resetting(Actor002,CharaPos110061_02_003,CameraPos110061_02_003)
turn_chara(Actor002,-66.9,0)
turn_chara(Actor001,74,0)
wait_time(0.5)
setup_small_camera_start(Camera002)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:私、これからロンディニウムに行って子供たちにお願いしてこようと思います
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020051")

-- ▼直接出力
voice_play("VO_101030_sp_0001_1")
-- ▲直接出力

	--★★エレイン★★:先輩。話を聞いていただいてどうもありがとうございました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020053")

	PlayAction(Actor002,"to  Std_Talk")

	--★★エレイン★★:すぐにできるようになるかはわからないけれど私、もう少し勇気を出してみます
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020054")

-- ▼直接出力
PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力

	--★★エレイン★★:怖がらずに<br>相手の目をまっすぐに見られるように
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_05020055")

-- ▼直接出力
local trustParam = set_communication_rankup("エレイン_コミュランク", "エレイン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
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
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
