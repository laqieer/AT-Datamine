-- このluaスクリプトは、EA_066_032.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-90,CharaPos114011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_003)
	Camera004 = SetTemplate("Actor005",nil,CharaPos114011_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_001)
	Camera005 = SetTemplate("Actor006",30.8,CharaPos114011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_002)
	Camera006 = SetTemplate("Actor007",58,CharaPos114011_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_007)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
turn_lookat(Actor002,Actor001,0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
turn_lookat(Actor003,Actor001,0)
keep_ik_lookat(Actor003,Actor001,"J_Head")
lookat_weight(Actor003,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
load_image("201010890", "content_still_20101089_image", "201010890_StillImage")
--エフェクト開始
on_cameraframe(2) --カメラ四隅にエフェクトを出す
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("201010890", 0.0, 0.0, 0.0) --回想スチルを表示
-- ▲直接出力
-- ▼直接出力
load_image("201010790", "content_still_20101079_image", "201010790_StillImage")
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{-3.18,0,0.07})
set_pos(Actor006,{-3.45,0.004,-0.92})
set_pos(Actor007,{-4.24,0,0.322})
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_LarowShop")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Reconnaissance")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Battle_General1_Intro")
-- ▲直接出力
-- ▼直接出力
hideobj01 = get_object("Npc_501_03_Nbl_Std01_Loop")
set_pos(hideobj01, {0,-20, 0})
hideobj02 = get_object("Npc_001_02_Com_Std01_Loop")
set_pos(hideobj02, {0,-20, 0})
hideobj03 = get_object("Npc_001_03_Bad_Std01")
set_pos(hideobj03, {0,-20, 0})
hideobj04 = get_object("Npc_001_01_Imp_Std02_Loop")
set_pos(hideobj04, {0,-20, 0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101024","002","101024002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	Actor005 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
--エフェクト終了
off_cameraframe()
off_screencolor()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
bgm_play("Set_BGM_Bus_LPF_Volume_1")
-- ▲直接出力

	--★★男性Ｂ★★:その冒険者は『山をも打ち砕く力』を求めて<br>その遺跡に潜ったそうだ
	Talk(Actor004,"NPCNAME_0179","simple","N","EA_066_0320003")


	--★★男性Ｂ★★:すると遺跡の奥には魔物がウジャウジャ<br>絶体絶命！助けてくれ、と願ったそのとき
	Talk(Actor004,"NPCNAME_0179","simple","N","EA_066_0320004")


	--★★男性Ｂ★★:遺跡の奥から突如眩い光が溢れ出して<br>魔物たちが瞬時に消えたそうだ
	Talk(Actor004,"NPCNAME_0179","simple","N","EA_066_0320005")


	--★★男性Ｂ★★:光を放つそれは杯のような形をしていて<br>――まさに聖杯と呼ぶべき代物だったと
	Talk(Actor004,"NPCNAME_0179","simple","N","EA_066_0320006")

-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)

--スチル終了
hide_image()

setup_small_camera_start(Camera001)
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ラロゥ★★:あれ？なんだ、もう知ってたんだ
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0320008")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ラロゥ★★:この辺りで最近、急に『聖杯』の噂が流れ始めた<br>出所は同じ遺跡に潜った複数の冒険者
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0320009")


	--★★ラロゥ★★:伝説級の武具を求めて遺跡に潜って魔物に返り討ち<br>逃げ帰るときに聖杯の奇跡を見てる
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0320010")

-- ▼直接出力
setup_small_camera_end(Camera001)
setup_small_camera_start()
-- ▲直接出力

	--★★ラロゥ★★:で、その情報を聞きつけたローマ兵の残党が<br>ゾロゾロやってきた。狙いは明白だね
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0320011")


	--★★ヴォールス★★:………
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0320012")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力

	--★★ラロゥ★★:ちなみに伝説級の武具については誰ひとり<br>それっぽいものすら見つけていない
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0320013")


	--★★ラロゥ★★:こっちは期待薄かもね<br>でも、聖杯があるなら探索する価値はある
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0320014")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0007")
-- ▲直接出力

	--★★ヴォールス★★:だが聖杯は既に我々が見つけ出して<br>然るべきところにあるはずだ
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0320015")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)

--エフェクト開始
on_cameraframe(2) --カメラ四隅にエフェクトを出す
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("201010790", 0.0, 0.0, 0.0) --回想スチルを表示
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)

wait_time(2)

--回想スチルシーンの終了時
--フェードアウト
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)

--スチル終了
hide_image()

--エフェクト終了
off_cameraframe()
off_screencolor()

wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力

	--★★ヴォールス★★:聖杯を巡る噂話はこれまで幾度も聞いてきた<br>そしてそのどれもがただの与太話
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0320017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0033")
-- ▲直接出力

	--★★ヴォールス★★:そんなものに縋らねばならないとは<br>ローマの残党はよほど行き詰まっているようだな
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0320018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0007")
-- ▲直接出力

	--★★ラロゥ★★:まぁ、行き詰まってることについては<br>否定はしないけどさ
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0320019")


	--★★ラロゥ★★:でもアンタたちが見つけた聖杯と<br>今ウワサになってるのは別物かもしれないよ
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0320020")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★ラロゥ★★:だってこの聖杯のウワサが出始めたのはつい最近<br>バルバロイがいなくなった後のことらしいから
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0320021")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ヴォールス★★:…！そうなのか
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0320022")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ラロゥ★★:なんでも、ここから少し西にある島には<br>かつて妖精が隠れていた遺跡があるんだって
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0320023")


	--★★ラロゥ★★:そこに太古の遺物が色々眠ってるって話<br>伝説級の武具のウワサはそのうちのひとつ
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0320024")


	--★★ラロゥ★★:今までは妖精が身を隠す為に施していた<br>封印があったらしいんだけど…
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0320025")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クレア","0009")
-- ▲直接出力

	--★★クレア★★:それが解けたんじゃないかと言われてる、と<br>わたしも街で聞いたわ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0320026")

-- ▼直接出力
setup_small_camera_end(RndCamera001)
-- ▲直接出力

	--★★クレア★★:冒険者曰く、遺跡の中から怪しい雰囲気が漂って<br>周辺の魔物が活発化している
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0320027")


	--★★クレア★★:恐らく長年の封印が解け<br>中のものが溢れ出ているのではないか、と
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0320028")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラロゥ★★:さすが探偵、調べが早いね
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0320029")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★クレア★★:タイミング的には聖域化がきっかけと<br>考えられなくもない。あくまで仮説だけど
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0320030")


	--★★クレア★★:でももし妖精が隠れ住んでいたことが<br>本当なら『聖杯』もあるかもしれない
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0320031")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ヴォールス★★:………
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0320032")

-- ▼直接出力
bgm_play("BGM_ADV_LarowShop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ラロゥ★★:なんにせよ、ただのウワサ話って切り捨てるには<br>気になるところが多すぎるよね
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0320033")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0008")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ヴォールス★★:…ひとつ、疑問なんだが<br>聖杯は、そんなにたくさんあるものなのか？
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0320034")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("クレア","0011")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クレア★★:あれば乾杯できるわね
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0320035")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
PlayPartVoiceDirect("ヴォールス","0019")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ヴォールス★★:あのな…
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0320036")

-- ▼直接出力
setup_small_camera_end(RndCamera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
PlayPartVoiceDirect("ラロゥ","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラロゥ★★:けど、万が一本物だったらラッキーでしょ？<br>なんたって聖杯は願いを叶えてくれるんだからさ
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0320037")

	change_face(Actor002,"Normal")

	--★★ヴォールス★★:………
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0320038")

	change_face(Actor003,"Normal")

	--★★クレア★★:どのみちローマ兵の残党の動きを<br>放置するわけにもいかないんじゃない？
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0320039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayPartVoiceDirect("ヴォールス_002","0034")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ヴォールス★★:…それは、そうだが――
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0320040")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
-- ▼直接出力
local gopos = {-0.992,0,1.218}
local gopos2 = {-1.544,0.004,0.425}
local gopos3 = {-1.396,0,1.947}
local actor = {Actor005,Actor006,Actor007}
local goalpos = {gopos,gopos2,gopos3}
CloseTalkWindow()
setup_small_camera_start()
for i = 1 , #actor do
    Appear(actor[i])
    turn_lookat(actor[i],Actor002,0)
    PlayActionDirect(actor[i],"to Wlk")
    slidemove(actor[i], goalpos[i], 2)
    if i < #actor then
wait_time(0.1)
    end
end
wait_time(1.6)
setup_small_camera_end()
setup_small_camera_start(Camera004)
wait_time(0.2)
for i = 1 , #actor do
    PlayActionDirect(actor[i],"to Std_Loop")
    if i < #actor then
wait_time(0.1)
    end
end
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Reconnaissance")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("山賊","0003")
-- ▲直接出力

	--★★盗賊★★:おいおい、面白そうな話をしてるじゃねえか
	Talk(Actor005,"NPCNAME_0283","speech","N","EA_066_0320042")

-- ▼直接出力
CloseTalkWindow()
local actor = {Actor003,Actor002,Actor001}
local rotate = {210,220,-120}
for i = 1 , #actor do
    keep_delay_ik_lookat(actor[i],Actor005,"J_Head",1.0)
    PlayActionDirect(actor[i],"to Wlk")
    turn_chara(actor[i],rotate[i],0.4)
    if i < #actor then
wait_time(0.1)
    end
end
wait_time(0.2)
for i = 1 , #actor do
    PlayActionDirect(actor[i],"to Std_Loop")
    if i < #actor then
wait_time(0.1)
    end
end
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("山賊","0010")
-- ▲直接出力

	--★★盗賊★★:その遺跡には代わりに俺たちが行ってやるからよ<br>お前らはここで大人しくしてるんだな
	Talk(Actor005,"NPCNAME_0283","speech","N","EA_066_0320043")

-- ▼直接出力
setup_small_camera_end(Camera004)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラロゥ★★:うわ…出たよ、ハイエナ<br>自分で情報を集める根性もないくせに
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0320044")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("山賊","0020")
-- ▲直接出力

	--★★盗賊★★:うるせえ！ログレスもローマも関係ねえ<br>お宝は全部まとめて俺たちがいただくぜ！
	Talk(Actor005,"NPCNAME_0283","speech","N","EA_066_0320045")

-- ▼直接出力
bgm_play("BGM_Battle_General1_Intro")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("201010890", "content_still_20101089_image", "201010890_StillImage")
load_image_preload("201010790", "content_still_20101079_image", "201010790_StillImage")
preload_sound("BGM_ADV_LarowShop")
preload_sound("BGM_ADV_Reconnaissance")
preload_sound("BGM_Battle_General1_Intro")
	InitializeLoad_Preload()
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101024","002","101024002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
