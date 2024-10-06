-- このluaスクリプトは、CO_101066_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110151_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110151_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_002)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110151)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
voice_play("VO_101066_sp_0001_1")
-- ▲直接出力

	--★★ブレイズ★★:さて…まずはワシがどんな研究をしているか<br>説明をしようかのう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020002")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ブレイズ★★:ワシはここでバルバロイや継承者について<br>その生態を解明しようと日々研究しておるのじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020003")

	open_select_window_tag(Actor001,"Normal","CO_101066_02020005","CO_101066_02020006","CO_101066_02020007")
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

	--★★ノワール★★:どうして学園で研究を？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_02020009")

	change_face(Actor002,"Normal")

	--★★ブレイズ★★:この学園は、アーサー王の思想のもと<br>キラーズ因子の多い者が集められておるじゃろ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:バルバロイに対抗し得る力を持つ者が集まる<br>この学園なら、研究もはかどると思ってのう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:継承者について研究って？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_02020013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:伝承によれば、継承者はバルバロイを倒すための<br>切り札のようなものじゃという
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020014")

	change_face(Actor002,"Normal")

	--★★ブレイズ★★:ゆえに継承者についても研究せねばならんのじゃ<br>バルバロイ研究の一環としてな
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020015")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0045")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ、すごいんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_02020017")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0015")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ブレイズ★★:こりゃ！なんじゃその気のない返事は～！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020018")

	change_face(Actor002,"Anger")

	--★★ブレイズ★★:まったく、最近の若者ときたら！<br>ま、そういう素直な反応も嫌いじゃないがの！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020019")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:どっちなんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_02020020")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:ふぉっふぉ<br>大人に生意気なことを言うのは子供の特権じゃな
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020021")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:後はそうじゃなあ<br>オブリヴィエについても研究しておる
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020023")

	change_face(Actor001,"Normal")

	--★★ノワール★★:オブリヴィエって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_02020024")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0019")
-- ▲直接出力

	--★★ブレイズ★★:うーん、なんといってよいものかのう<br>ここではないどこかへつながる場所というか…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020025")


	--★★ブレイズ★★:まぁ、実際行ってみんとわからんじゃろうなぁ<br>ワシも詳しくはわからんし
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020027")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0045")
-- ▲直接出力

	--★★ノワール★★:へえ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_02020028")

-- ▼直接出力
CloseTalkWindow()
wait_time(1)
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そういえば、この前授業であんたが話してくれた<br>冒険の話、面白かったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_02020030")


	--★★ノワール★★:見せてくれた道具とかも<br>初めて見るものばかりでワクワクしたし…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_02020031")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0045")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:さすがはノワール。目の付けどころがいい！<br>じゃあもう少し近くで見せてやるとするかのう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020032")

	change_face(Actor002,"Normal")

	--★★ブレイズ★★:これらはワシが大魔法使いとして<br>冒険していたころの思い出の品なんじゃよ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020034")


	--★★ブレイズ★★:これはワシの髭が30cmの頃じゃったかの
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020035")


	--★★ブレイズ★★:海の向こうの大陸で暴れまわる魔物を倒し<br>その褒美として授かった褒章じゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020036")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0045")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ、すごいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_02020037")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:そうじゃろそうじゃろ？<br>で、これはワシの髭が23cmだった頃
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020038")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:何隻もの船を海に沈めた<br>化け物イカを退治したときにもらった冠
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020039")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ブレイズ★★:こっちはワシの髭が36cmの頃<br>大国の王の命を受け
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020040")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ブレイズ★★:地の底で目覚めた魔王を<br>再び眠りにつかせたときに頂戴した黄金の杖
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020042")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ブレイズ★★:それからそれから…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020043")

-- ▼直接出力
setup_small_camera_end(RndCamera008)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0048")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あ、もうそのへんで大丈夫だ<br>長くなりそうだし…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_02020045")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0007")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ブレイズ★★:ふむ、そうか？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:まだまだ話したりないところじゃが<br>ワシの偉大さを少しはわかってくれたかの？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020047")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、まあ、うん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_02020048")


	--★★ノワール★★:けどさ、そんな世界を股にかける大魔法使いが<br>なんで今は学園の教師なんかやってるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_02020049")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0007")
-- ▲直接出力

	--★★ブレイズ★★:ワシは魔法使いとして頂点を極めたからのう<br>今後は後進の育成でも…と思っておったんじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020051")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ブレイズ★★:そんな折、この学園で教師をしてほしいと<br>アーサー王から直々に頼まれてな
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020052")


	--★★ブレイズ★★:王の頼みを聞かないわけにはいくまい？<br>ましてアーサー王は愛弟子マーリンの主人じゃし
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020053")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0045")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ…<br>アーサーって、教員集めまでしているのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_02020054")


	--★★ブレイズ★★:アーサー王は生徒たちのために<br>よりよい学園を作ろうとがんばっておるのじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020055")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★ブレイズ★★:それにワシの研究に必要な環境も整えてくれて<br>本当に立派な方じゃよ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020056")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0019")
-- ▲直接出力

	--★★ブレイズ★★:ただ、女難の相があるかもしれんがの～
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020057")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力

	--★★ノワール★★:女難の相？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_02020058")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ブレイズ★★:うむ。それがアキレス腱とならねばよいが
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020059")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:まぁ…老いぼれにできることは<br>ただ見守ることだけじゃな
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020060")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_02020061")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_MA_01C109_01_Bell")
wait_time(2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end(RndCamera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ブレイズ★★:おっと…なんじゃ、もうこんな時間か
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020063")

	PlayAction(Actor002,"to Greet_one")
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:それじゃ、本格的な研究は<br>次から始めるとしよう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_02020064")

-- ▼直接出力
local trustParam = set_communication_rankup("ブレイズ_コミュランク", "ブレイズ_親密度")
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
	load_area_scene_preload(110151)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
