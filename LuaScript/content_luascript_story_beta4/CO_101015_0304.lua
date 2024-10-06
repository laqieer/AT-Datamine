-- このluaスクリプトは、CO_101015_0304.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_015)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit02_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_014,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_014)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
 --黒背景読込
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
 -- 黒背景の表示
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:失礼します…って<br>アーサー！？大丈夫か！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_03040002")

-- ▼直接出力
 --白黒終了フェードアウト
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:駄目だ<br>俺はもう駄目だ…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040003")

	PlayAction(Actor002,"to Sit02_BA01")

	--★★アーサー★★:あの店のホットドッグを食わねば…<br>俺はもう仕事が出来ん…！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…これ、マーリンさんから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_03040006")

	change_face(Actor002,"Surprise")

	--★★アーサー★★:おおお！買ってきてくれたのか！？<br>感謝するぞ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:ではさっそく…もぐもぐ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101015_03040011","CO_101015_03040012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:書類の上でホットドッグって…<br>ソースこぼすなよ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_03040014")

-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:ふっ…俺が今までどれだけ<br>ホットドッグを食べてきたと思っている
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040015")

	change_face(Actor002,"Surprise")

	--★★アーサー★★:ソースをこぼさず食べることくらい余裕…<br>…って、あああっ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040016")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ケイ", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ケイ★★:…アーサー、お前というやつは
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_03040017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いい食いっぷりだな<br>…俺も食べたくなってきた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_03040019")

-- ▼直接出力
PlayPartVoice("アーサー", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:ハハハ！わかるぞ、その気持ち！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040020")

	PlayAction(Actor002,"to Sit02_Talk")
	change_face(Actor002,"Normal")

	--★★アーサー★★:他人が食べてるB級グルメは<br>いつも以上に美味そうに見えるからな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040021")

-- ▼直接出力
PlayPartVoice("アーサー", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:だが、これはやらん！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040022")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:取らないって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_03040023")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ケイ★★:相変わらずそんな物ばかり食べて…<br>まったく、マーリンも甘すぎるな
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_03040025")

	PlayAction(Actor002,"to Sit02_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:いいじゃないか！俺の好物なんだから！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040026")

	change_face(Actor003,"Normal")

	--★★ケイ★★:わかっている。だから禁止はしてないだろう<br>節度を守れと言っているだけだ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_03040027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ★★:お前は常に王としての資質を問われる立場だ<br>それを自覚して、もう少し食にも気を配れと…
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_03040028")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:ホットドッグはいいものだろ、義兄さん<br>小さい頃、よく一緒に食べたじゃないか
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040030")

	change_face(Actor003,"Sad")

	--★★ケイ★★:…昔の話だろう。それに、お前は本当は――
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_03040031")

	PlayAction(Actor002,"to Sit02_Talk")

	--★★アーサー★★:義兄さん<br>俺は自分の出自を恥じたことはないぞ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040033")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:出自って…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_03040035")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:俺は、ログレスの片田舎にある<br>孤児院で育ったんだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:孤児院？なんで…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_03040037")


	--★★アーサー★★:まあ、王宮には色々事情があってな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040038")

	PlayAction(Actor002,"to Sit02_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:そこで義兄さんやマーリンと出会った<br>共に学び、鍛え、そしてたくさん遊んだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ケイやマーリンさんも孤児院に…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_03040040")


	--★★アーサー★★:正確にいうとマーリンは<br>孤児院に預けられていたわけではないがな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040041")


	--★★アーサー★★:まあ、それはともかくとして<br>３人並んでホットドッグを食べたりもした
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040042")

-- ▼直接出力
PlayPartVoice("アーサー", "悩む")
-- ▲直接出力

	--★★アーサー★★:義兄さんにとってはもう過去の話なんだろう<br>…いや。もちろん、俺にとってもそうだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040043")


	--★★アーサー★★:だが、その過去の大切な記憶こそが――
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040044")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:…アーサー？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_03040046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:…あの孤児院での暮らしは<br>豊かであったとは言えないが
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040048")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:とても楽しい日々だった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040049")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:そうか…だからあんたは<br>あんなにホットドッグこだわりが――…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_03040050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…ん？でもあんた確か<br>カツサンドも食べてたよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_03040051")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:ああ、食べていた！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040052")


	--★★アーサー★★:カツサンドは旨いからな！<br>特にあの油ギットギトな感じが最高にたまらん！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040053")

-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力

	--★★アーサー★★:…カツサンドの話をしていたら<br>なんだかそっちも食べたくなったな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040054")

	change_face(Actor002,"Surprise")

	--★★アーサー★★:む！ギットギトといえば…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040055")

	PlayAction(Actor002,"to Sit02_Talk")

	--★★アーサー★★:小麦粉で作った生地を鉄板でじゅうじゅう焼いて<br>ソースまみれにした食べ物が
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040056")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:マーケットの屋台で<br>売り出されたと聞いたな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040057")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:よし！仕事も終わったことだし…<br>グルメツアーへ出発するか！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03040058")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:（…やっぱりただ単に<br>B級グルメが好きなだけか…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101015_03040060")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("アーサー_コミュランク", "アーサー_親密度")
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
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
