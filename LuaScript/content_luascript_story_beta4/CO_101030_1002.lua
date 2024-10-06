-- このluaスクリプトは、CO_101030_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114091_01","114091_01_h")
Include("content_adv_advsmall_114091_01","Template114091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-115,CharaPos114091_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114091_01,CameraPos114091_01_004)
	Camera002 = SetTemplate("Actor002",130,CharaPos114091_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName114091_01,CameraPos114091_01_003)
	InitializeTemplateRandomCamera114091_01()
	InitializeTemplate114091_01()
-- ▼直接出力
tegami = setup_prop_object(10106003)
off_active(tegami)
tegami_offset = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
-- ▼直接出力
load_image("103050190", "content_still_10305019_image", "103050190_StillImage")
set_scale_image(0.8,0.8)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114091)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(0.5)
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:たしかここは<br>キミと初めて会った花畑…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_10020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:そうです<br>私が初めて先輩に手紙を渡した場所
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020003")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera090)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,75,0.3)
wait_time(0.3)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
PlayActionDirect(Actor002,"to Sit10")
SkipDefaultMotion(Actor002)
wait_time(1)
-- ▲直接出力

	--★★エレイン★★:このくらいでいいかな…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020005")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,130,0.3)
wait_time(0.3)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どうするんだ、その花？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_10020006")

-- ▼直接出力
PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:トビーくんと一緒に<br>お墓参りに行くことになったんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020007")

	change_face(Actor002,"Normal")

	--★★エレイン★★:トビーくんのお父さんとお母さんの
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:なるほど<br>そのための花か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_10020009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力

	--★★エレイン★★:先輩<br>私ね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020011")


	--★★エレイン★★:トビーくんの様子を見に帰ったとき<br>村のみなさんと話すようにしてるんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★エレイン★★:話せるようになったんです<br>みなさんの目を見て
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101030_10020016","CO_101030_10020017")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:かわれたんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_10020019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:はい<br>まだ声が上ずったりすることもありますけど
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020020")

	change_face(Actor002,"Normal")

	--★★エレイン★★:みなさんとアストラットの将来について<br>語り合っています
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020021")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★エレイン★★:アストラットの領主…<br>いえ、アストラットの美姫として
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか<br>みんなはなんて言ってるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_10020024")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("エレイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:それが、その…<br>すごく恥ずかしいんですけど
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020025")

	change_face(Actor002,"Normal")

	--★★エレイン★★:「アストラットの美姫が<br>この村を発展させてくれる」って
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020026")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0025")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:まだ私、なにも始められてないのに…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020027")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
CloseTalkWindow()
wait_time(1.5)
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
voice_play("VO_101030_sp_0001_1")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:先輩、見ててくださいね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★エレイン★★:何年…<br>いえ、何十年かかるかわかりませんけど
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020030")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★エレイン★★:アストラットをログレスに負けないくらい<br>賑やかな場所にしてみせますから！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020031")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:期待してる<br>キミならできるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_10020032")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0036")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:全部、先輩のおかげです<br>ありがとうございました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020034")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そんな…<br>俺はなにもしてないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_10020036")

-- ▼直接出力
PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:ふふっ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:そうだ。手紙を預かって来たんです<br>トビーくんから先輩あてに
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020039")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:トビーが俺に？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_10020040")

-- ▼直接出力
setup_small_camera_start()
	change_face(Actor001, "Normal")
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:はい<br>私が代筆しました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020041")

-- ▼直接出力
setup_small_camera_start(Camera002)
on_parent(tegami,Actor001, "Loc_weapon_constrint_L", tegami_offset)
on_active(tegami)
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor002,"to TakeHand")

	--★★エレイン★★:トビーくんの感謝の気持ちが綴られてます<br>読んであげてください
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020042")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01105_28_Paper")
-- ▲直接出力
	PlayAction(Actor001,"to ReadLetter")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そっか<br>えーと、なになに…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_10020044")


	--★★ノワール★★:「いつもそばにいてくれてありがとう<br>優しく見守ってくれてありがとう」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_10020045")


	--★★ノワール★★:「他の方とは<br>目を見て話せるようになったつもりですが」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_10020046")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:…あ、あれっ？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020048")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ノワール★★:「あなたに見つめられていると<br>どうしても胸がドキドキしてしまうので」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_10020049")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★ノワール★★:「やっぱりこうして<br>手紙で想いを伝えさせていただきます」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_10020050")

-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0029")
PlayActionDirect(Actor002,"to  Std_Surp")
SkipDefaultMotion(Actor002)
-- ▲直接出力

	--★★エレイン★★:ちょっ！？<br>ちょっと、ま、待ってください！！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020052")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:「あの花畑で初めてお会いしてから<br>ずっとあなたのことを…」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_10020053")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0031")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Surprise")

	--★★エレイン★★:わーっ！<br>わーーっ、それ以上、読んだらダメです！！
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","CO_101030_10020055")

-- ▼直接出力
off_parent(tegami)
off_active(tegami)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	close_cutin()
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え、だって…俺あての手紙なんだろ？<br>トビーからの
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_10020057")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0021")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:先輩あての手紙ではあるんですけど
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020058")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★エレイン★★:まだ読んじゃダメっていうか…<br>読んでほしくないっていうか
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020059")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★エレイン★★:読んでほしいっていうか…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020060")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_10020061")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera002)
end
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0037")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★エレイン★★:こ、心の準備ができたらあらためて！<br>今日はこれで失礼しますっ！！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_10020062")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
show_image("103050190", 0.0, 0.0, STILL_SWITCH_TIME ,true,false) 
se_play("SE_ADV_CO_101013_0503_Foot_Grass_3_Peaple")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
se_play("SE_ADV_CO_101013_0503_Foot_Grass_3_Peaple")
voice_play("VO_101009_sp_0016_2")
-- ▲直接出力

	--★★ノワール★★:お、おい！<br>トビーの手紙は…？
	Talk(Actor001,"CHRNAME_NOIR","speech","N","CO_101030_10020064")

-- ▼直接出力
PlayPartVoiceDirect("エレイン","0021")
-- ▲直接出力

	--★★エレイン★★:まだまだだ、私
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","CO_101030_10020066")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("エレイン_コミュランク", "エレイン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10106003)
tegami_offset = {0,0,0,0,0,0}
load_image_preload("103050190", "content_still_10305019_image", "103050190_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(114091)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
